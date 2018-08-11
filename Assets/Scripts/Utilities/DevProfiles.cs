﻿//#define TESTING

using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using GTAConfig = SanAndreasUnity.Utilities.Config;
using System;
using SanAndreasUnity.Utilities;

public class DevProfiles
{
    private static JObject _obj;

    public static JObject obj
    {
        get
        {
            if (_obj == null)
                _obj = DeserializeProfiles();

#if TESTING
            Debug.LogWarning("_obj null?: "+(_obj == null));
#endif

            return _obj;
        }
    }

#if TESTING
    public static int ActiveProfile
    {
        get
        {
            try
            {
                Debug.Log("Available keys: "+string.Join(", ", obj.Properties().Select(p => p.Name)));

                var a = obj[GTAConfig.const_active_dev_profile];

                Debug.LogWarning("a null?: "+(a == null));

                var b = a.ToObject<int>();

                Debug.LogWarning("b null?: " + (b == null));

                var c = b.FirstOrDefault(x => x.Key == SystemInfo.deviceUniqueIdentifier);

                Debug.LogWarning("c null?: " + (c.Equals(default(IEnumerable<KeyValuePair<string, int>>))));

                return c.Value;
            }
            catch(Exception ex)
            {
                Debug.LogError(ex.Message);
                return -1;
            }
        }
    }
#else
    public static int ActiveProfile
    {
        get
        {
            try
            {
                return obj[GTAConfig.const_active_dev_profile].ToObject<int>();
            }
            catch
            {
                return -1;
            }
        }
    }

    /*public static string ActiveProfilePath
    {
        get
        {
            try
            {
                return GTAConfig.Get<List<string>>(GTAConfig.const_dev_profiles).Where(x => x.Key == SystemInfo.deviceUniqueIdentifier).FirstOrDefault().Value[ActiveProfile];
            }
            catch
            {
                throw new Exception(string.Format("You must set the GTA path, because if not the game won't launch. You can set it manually using this id: '{0}', or setting it with the Editor popup.", SystemInfo.deviceUniqueIdentifier));
            }
        }
    }*/
#endif

    public static string ActiveProfilePath
    {
        get
        {
            return GTAConfig.Get<List<string>>(GTAConfig.const_dev_profiles)[ActiveProfile];
        }
    }

    public static string LastDevProfilePath
    {
        get
        {
            try
            {
                return _obj[GTAConfig.const_dev_profiles].ToObject<List<string>>().Last();
            }
            catch
            {
                return "";
            }
        }
    }

    private static JObject DeserializeProfiles()
    {
        string s = "";
        return DeserializeProfiles(out s);
    }

    private static JObject DeserializeProfiles(out string contents)
    {
        string configPath = GTAConfig.UserFileName;

#if TESTING
        Debug.Log(configPath);
#endif

        contents = File.ReadAllText(configPath);

        return contents.JsonDeserialize<JObject>();
    }

    public static string GetPathFromProfileAt(int index)
    {
        List<string> devs = _obj[GTAConfig.const_dev_profiles].ToObject<List<string>>();

        return devs[index];
    }

    public static string CheckDevProfiles(Func<string> folderList)
    {
        //game_path = Environment.GetEnvironmentVariable("ProgramFiles"); //...
        string game_path = "",
               contents = "";

        _obj = DeserializeProfiles(out contents);

        var prop = obj[GTAConfig.const_game_dir];
        string game_dir = prop != null ? prop.ToObject<string>() : "";

        bool isSet = true;

        if (prop != null)
            obj.Remove(GTAConfig.const_game_dir);

        var objDev = obj[GTAConfig.const_dev_profiles];

        if (objDev != null)
            game_dir = GetPathFromProfileAt(ActiveProfile);
        else
            isSet = false;

        if (string.IsNullOrEmpty(game_dir))
            game_path = folderList();
        else
            game_path = game_dir;

        if (!isSet)
            AddNewPath(game_path);

        string postContents = obj.JsonSerialize(true);
        if (postContents != contents)
            SaveChanges();

        return game_path;
    }

    public static void AddNewPath(string path, bool setActive = true)
    {
        var objDev = _obj[GTAConfig.const_dev_profiles];

        List<string> devs = objDev != null ? objDev.ToObject<List<string>>() : new List<string>();

        devs.Add(path);

        _obj[GTAConfig.const_dev_profiles] = JArray.FromObject(devs);

        if (setActive)
            SetDevActiveIndex(ref _obj, devs.Count - 1);
    }

    public static void EditPath(int index, string path, bool setActive = true)
    {
        var objDev = _obj[GTAConfig.const_dev_profiles];

        if (objDev == null) return;

        List<string> devs = objDev.ToObject<List<string>>();

        if (index > devs.Count) return;

        try
        {
            devs[index] = path;

            _obj[GTAConfig.const_dev_profiles] = JArray.FromObject(devs);

            if (setActive)
                SetDevActiveIndex(ref _obj, devs.Count - 1);
        }
        catch
        {
            Debug.LogError("Out of index when trying to edit path from dev profile!");
        }
    }

    public static void SetDevActiveIndex(ref JObject __obj, int index)
    {
        __obj[GTAConfig.const_active_dev_profile] = index;
    }

    public static bool ExistDevIndex(int index)
    {
        var devObj = obj[GTAConfig.const_dev_profiles];

        if (devObj == null) return false;

        var devDict = devObj.ToObject<List<string>>();

        if (devDict == null || (devDict != null && devDict.Count == 0)) return false;

        //Debug.LogFormat("Index: {0}; Count: {1}", index, devDict.Count - 1);
        return index <= devDict.Count;
    }

    public static void SaveChanges(JObject __obj = null)
    {
        if (__obj == null) __obj = _obj;

        // Serialize again
        File.WriteAllText(GTAConfig.UserFileName, __obj.JsonSerialize(true));
    }
}