using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public static class DynamicRoleDateModel
{

    private static string keyName = "RoleDate";
    private static string EquipName = "EquipDate";

    public static void Init()
    {
        if (PlayerPrefs.GetString(keyName) == "")
        {
            TextAsset ta = Resources.Load<TextAsset>("Json/Init");
            PlayerPrefs.SetString(keyName, ta.text);
        }
        if (PlayerPrefs.GetString(EquipName) == "")
        {
            TextAsset ta = Resources.Load<TextAsset>("Json/EuqipInit");
            PlayerPrefs.SetString(EquipName, ta.text);
        }

    }

    public static RoleDate ReadRoleDate()
    {
        string json = PlayerPrefs.GetString(keyName);
        Debug.Log("Read Player Info:" + json);
        RoleDate jd = JsonMapper.ToObject<RoleDate>(json);
        return jd;
    }

    public static List< EquipDate> ReadEquipDate()
    {
        string json = PlayerPrefs.GetString(EquipName);
        Debug.Log("Read Player EquipInfo:" + json);
        List<EquipDate> ed = JsonMapper.ToObject< List<EquipDate>  >(json);
        return ed;
    }

}
