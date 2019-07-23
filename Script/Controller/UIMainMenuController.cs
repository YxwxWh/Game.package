using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenuController : MonoBehaviour {

    void Start()
    {
        DynamicRoleDateModel.Init();
    }
    public void DeLAll()
    {
        PlayerPrefs.DeleteAll();
    }

    public void PackageClick()
    {
        Prefabs.LoadUI("UI/Perfabs/Package");
    }
}
