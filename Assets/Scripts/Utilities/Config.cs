﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Facepunch.Networking;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace SanAndreasUnity.Utilities
{
    public static class Config
    {
        public static string FileName
        {
            get { return "config.json"; }
        }

        public static string UserFileName
        {
            get { return "config.user.json"; }
        }

        public static string FilePath
        {
            get { return Path.Combine(Application.dataPath, Path.Combine("..", FileName)); }
        }

        public static string UserFilePath
        {
            get { return Path.Combine(Application.dataPath, Path.Combine("..", UserFileName)); }
        }

        private static readonly JObject _root;
        private static readonly JObject _user;

        private static readonly Dictionary<string, string> _substitutions;

        static Config()
        {
            if (!File.Exists(UserFilePath)) {
                File.WriteAllText(UserFilePath, "{\r\n    // Specify overrides here\r\n}\r\n");
            }

            _substitutions = new Dictionary<string,string>();

            _root = JObject.Parse(File.ReadAllText(FilePath));
            _user = JObject.Parse(File.ReadAllText(UserFilePath));
        }

        private static TVal ConvertVal<TVal>(JToken val)
        {
            return (TVal) Convert.ChangeType(val, typeof(TVal));
        }

        public static TVal Get<TVal>(string key)
        {
            var userVal = _user[key];
            if (userVal != null) {
                try {
                    return ConvertVal<TVal>(userVal);
                } catch {
                    Debug.LogWarningFormat("[config] Invalid value for key '{0}'.", key);
                }
            }

            return ConvertVal<TVal>(_root[key]);
        }

        private static string GetSubstitution(string key)
        {
            if (_substitutions.ContainsKey(key)) return _substitutions[key];
            var subs = ReplaceSubstitutions(Get<string>(key));
            _substitutions.Add(key, subs);
            return subs;
        }

        private static readonly Regex _regex = new Regex(@"\$\{(?<key>[a-z0-9_]+)\}", RegexOptions.Compiled);
        private static string ReplaceSubstitutions(string value)
        {
            return _regex.Replace(value, x => GetSubstitution(x.Groups["key"].Value));
        }

        public static string GetPath(string key)
        {
            return ReplaceSubstitutions(Get<string>(key));
        }

        public static string[] GetPaths(string key)
        {
            return Get<JArray>(key)
                .Select(x => ReplaceSubstitutions((string) x))
                .ToArray();
        }
    }
}
