﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SanAndreasUnity.Importing.Vehicles
{
    public enum DriveType
    {
        Forward,
        Rear,
        FourWheel
    }

    public enum EngineType
    {
        Petrol,
        Diesel,
        Electric
    }

    public static class Handling
    {
        #region Reflection

        [Flags]
        private enum ColumnFlags
        {
            Default = 0,
            HexNumber = 1
        }

        [AttributeUsage(AttributeTargets.Property)]
        private class ColumnAttribute : Attribute
        {
            public readonly int Value;
            public readonly ColumnFlags Flags;

            public bool IsHexNumber
            {
                get {  return (Flags & ColumnFlags.HexNumber) == ColumnFlags.HexNumber; }
            }

            public ColumnAttribute(int value, ColumnFlags flags = ColumnFlags.Default)
            {
                Value = value;
                Flags = flags;
            }
        }

        [AttributeUsage(AttributeTargets.Class)]
        private class PrefixAttribute : Attribute
        {
            public readonly char Value;
            public PrefixAttribute(char value) { Value = value; }
        }

        public interface IEntry { }

        public interface IVehicleEntry : IEntry
        {
            string Id { get; set; }
        }

        public abstract class Entry<TEntry> : IEntry
            where TEntry : Entry<TEntry>
        {
            private static Dictionary<int, Action<TEntry, string>> _sParsers;

            private static void GenerateParsers()
            {
                _sParsers = new Dictionary<int, Action<TEntry, string>>();

                var type = typeof(TEntry);

                var selfParam = Expression.Parameter(type, "self");
                var hexNumConst = Expression.Constant(NumberStyles.HexNumber);
                var valParam = Expression.Parameter(typeof(String), "val");

                foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)) {
                    var attrib = (ColumnAttribute) prop.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
                    if (attrib == null) continue;

                    var set = prop.GetSetMethod(true);
                    if (set == null) {
                        throw new Exception("Set method is inaccessible");
                    }

                    Expression input = valParam;

                    if (prop.PropertyType != typeof(string)) {
                        var argTypes = attrib.IsHexNumber
                            ? new [] { typeof(string), typeof(NumberStyles) }
                            : new [] { typeof(string) };
                        
                        var convert = prop.PropertyType.GetMethod("Parse",
                            BindingFlags.Static | BindingFlags.Public,
                            null, argTypes, null);

                        if (convert == null) {
                            throw new Exception(String.Format("Cannot convert a string to {0}", prop.PropertyType));
                        }

                        input = attrib.IsHexNumber
                            ? Expression.Call(convert, input, hexNumConst)
                            : Expression.Call(convert, input);
                    }

                    var setCall = Expression.Call(selfParam, set, input);
                    var lambda = Expression.Lambda<Action<TEntry, string>>(
                        setCall, selfParam, valParam).Compile();

                    _sParsers.Add(attrib.Value, lambda);
                }
            }

            protected Entry(string line)
            {
                if (_sParsers == null) {
                    GenerateParsers();
                }

                var split = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var self = (TEntry) this;

                for (var i = 0; i < split.Length; ++i) {
                    if (_sParsers.ContainsKey(i)) {
                        _sParsers[i](self, split[i]);
                    }
                }
            }
        }

        private static Dictionary<char, Func<String, IEntry>> _sCtors;

        private static readonly List<IEntry> _sEntries = new List<IEntry>();

        private static void GenerateCtors()
        {
            _sCtors = new Dictionary<char, Func<string, IEntry>>();

            var param = Expression.Parameter(typeof(String), "line");

            foreach (var type in typeof(Handling).GetNestedTypes()) {
                if (type.IsAbstract) continue;
                if (type.IsInterface) continue;
                if (!typeof(IEntry).IsAssignableFrom(type)) continue;
                var attrib = (PrefixAttribute) type.GetCustomAttributes(typeof(PrefixAttribute), true).FirstOrDefault();
                var prefix = attrib != null ? attrib.Value : '\0';

                var ctor = type.GetConstructor(new[] { typeof(string) });
                var ctorCall = Expression.New(ctor, param);
                var cast = Expression.Convert(ctorCall, typeof(IEntry));
                var lambda = Expression.Lambda<Func<String, IEntry>>(cast, param).Compile();

                _sCtors.Add(prefix, lambda);
            }
        }

        #endregion

        public class Car : Entry<Car>, IVehicleEntry
        {
            [Column(0)] public string Id { get; set; }
            [Column(1)] public float Mass { get; set; }
            [Column(2)] public float TurnMass { get; set; }
            [Column(3)] public float Drag { get; set; }
            [Column(4)] private float _CentreOfMassX { get; set; }
            [Column(5)] private float _CentreOfMassZ { get; set; }
            [Column(6)] private float _CentreOfMassY { get; set; }
            [Column(7)] public int BoyantPercent { get; set; }
            [Column(8)] public float TractionMult { get; set; }
            [Column(9)] public float TractionLoss { get; set; }
            [Column(10)] public float TractionBias { get; set; }

            [Column(11)] public int TransmissionGears { get; set; }
            [Column(12)] public float TransmissionMaxVel { get; set; }
            [Column(13)] public float TransmissionEngineAccel { get; set; }
            [Column(14)] public float TransmissionEngineInertia { get; set; }
            [Column(15)] private string _TransmissionDriveType { get; set; }
            [Column(16)] private string _TransmissionEngineType { get; set; }
            
            [Column(17)] public float BrakeDecel { get; set; }
            [Column(18)] public float BrakeBias { get; set; }
            [Column(19)] private int _AntiLockBrakes { get; set; }
            [Column(20)] public float SteeringLock { get; set; }

            [Column(21)] public float SuspensionForceLevel { get; set; }
            [Column(22)] public float SuspensionDampingLevel { get; set; }
            [Column(23)] public float SuspensionHighSpeedDamping { get; set; }
            [Column(24)] public float SuspensionUpperLimit { get; set; }
            [Column(25)] public float SuspensionLowerLimit { get; set; }
            [Column(26)] public float SuspensionFrontRearBias { get; set; }
            [Column(27)] public float SuspensionAntiDriveMult { get; set; }

            [Column(28)] public float SeatOffsetDistance { get; set; }
            [Column(29)] public float CollisionDamageMult { get; set; }
            [Column(30)] public int MonetaryValue { get; set; }

            [Column(31, ColumnFlags.HexNumber)] private ulong _ModelFlags { get; set; }
            [Column(32, ColumnFlags.HexNumber)] private ulong _HandlingFlags { get; set; }

            [Column(33)] private int _FrontLights { get; set; }
            [Column(34)] private int _RearLights { get; set; }

            [Column(35)] public int AnimGroup { get; set; }

            public UnityEngine.Vector3 CentreOfMass
            {
                get { return new UnityEngine.Vector3(_CentreOfMassX, _CentreOfMassY, _CentreOfMassZ); }
            }

            public DriveType TransmissionDriveType
            {
                get
                {
                    switch (_TransmissionDriveType) {
                        case "F": return DriveType.Forward;
                        case "R": return DriveType.Rear;
                        case "4": return DriveType.FourWheel;
                        default: throw new FormatException();
                    }
                }
            }

            public EngineType TransmissionEngineType
            {
                get
                {
                    switch (_TransmissionEngineType) {
                        case "P": return EngineType.Petrol;
                        case "D": return EngineType.Diesel;
                        case "E": return EngineType.Electric;
                        default: throw new FormatException();
                    }
                }
            }

            public bool AntiLockBrakes { get { return _AntiLockBrakes != 0; } }

            public Car(string line) : base(line) { }
        }

        public static void Load(string path)
        {
            if (_sCtors == null) {
                GenerateCtors();
            }

            using (var reader = File.OpenText(path)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    line = line.Trim();

                    if (line.Length == 0) continue;
                    if (line.StartsWith(";")) continue;

                    var prefix = line[0];

                    if (char.IsLetterOrDigit(prefix)) {
                        _sEntries.Add(_sCtors['\0'](line));
                        continue;
                    }

                    foreach (var pair in _sCtors) {
                        if (pair.Key != prefix) continue;
                        _sEntries.Add(pair.Value(line.Substring(1).TrimStart()));
                        break;
                    }
                }
            }
        }

        public static TEntry Get<TEntry>(String id)
            where TEntry : IVehicleEntry
        {
            return _sEntries.OfType<TEntry>().FirstOrDefault(x => x.Id == id);
        }
    }
}
