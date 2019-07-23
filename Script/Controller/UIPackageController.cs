using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class UIPackageController : MonoBehaviour {

    public UIPackageItemListView ListView;
    public UIPackageEquipItemDateView EquipList;

    public RoleDate Date;
    public List< EquipDate> E_Date;

    public List<ItemCompleteDate> CompleteDate;

    
    public static bool isDisplay = false;
    private void Start()
    {
        LoadItemList();
        LoadCharacterItem();
        
    }

    public void LoadItemList()
    {
        
        Date = DynamicRoleDateModel.ReadRoleDate();
        List<ItemCompleteDate> complete = StaticItemDateModel.ReadItemCompleteDate(Date.Items);

        CompleteDate = complete;
        if (complete.Count > 0)
        {          
            ListView.DisPlay(complete);
        }

    }

    public void LoadCharacterItem()
    {
        E_Date = DynamicRoleDateModel.ReadEquipDate();

        if (E_Date.Count>0)
        {
           EquipList.DisPlay(E_Date,CompleteDate);
        }
    }

    public void BackToMain()
    { 
        Destroy(gameObject);
    }
}
