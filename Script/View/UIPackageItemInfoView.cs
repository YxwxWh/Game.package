using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using LitJson;

public class UIPackageItemInfoView : MonoBehaviour
{

    public Image Icon, Frame;
    public Text Info, Name;
    private ItemCompleteDate _Date;



    public void DisPlay(ItemCompleteDate date)
    {
        _Date = date;
        string[] IconDate = date.Icon.Split('#');
        SpriteAtlas IconAtlas = Resources.Load<SpriteAtlas>("UI/" + IconDate[0]);
        Icon.sprite = IconAtlas.GetSprite(IconDate[1]);

        SpriteAtlas frameAtlas = Resources.Load<SpriteAtlas>("UI/Farme");
        switch (date.Color)
        {
            case 1:
                //通过精灵的名称，在图集中查找图片，赋值给框
                Frame.sprite = frameAtlas.GetSprite("heroframe-orange+");
                break;
            case 2:
                Frame.sprite = frameAtlas.GetSprite("heroframe-purple+++");
                break;
            case 3:
                Frame.sprite = frameAtlas.GetSprite("heroframe-blue++");
                break;
            case 4:
                Frame.sprite = frameAtlas.GetSprite("heroframe-gray");
                break;
        }
        Name.text = date.Name;



    }

    public void Drop()
    {
        string json = PlayerPrefs.GetString("RoleDate");
        RoleDate jd = JsonMapper.ToObject<RoleDate>(json);

        for (int i = 0; i < jd.Items.Count; i++)
        {

            if (jd.Items[i].ItemID == _Date.ItemID)
            {
                jd.Items[i].Count -= 1;
                if (jd.Items[i].Count==0)
                {
                    jd.Items.RemoveAt(i);
                    Destroy(gameObject);
                    UIPackageController.isDisplay = false;
                }
                break;
            }
        }
       
        string newJson = JsonMapper.ToJson(jd);
        PlayerPrefs.SetString("RoleDate", newJson);
        GameObject.Find("UI/Canvas/Package").GetComponent<UIPackageController>().LoadItemList();
        GameObject.Find("UI/Canvas/Package").GetComponent<UIPackageController>().LoadCharacterItem();
    }

    public void Equip()
    {
        string json = PlayerPrefs.GetString("EquipDate");
        List<EquipDate> ed = JsonMapper.ToObject<List<EquipDate>>(json);


        for (int i = 0; i < ed.Count; i++)
        {
            if (ed[i].Type==_Date.Type)
            {
                ed[i].ItemID = _Date.ItemID;
            }
        }

        string newJson = JsonMapper.ToJson(ed);
        PlayerPrefs.SetString("EquipDate", newJson);
        GameObject.Find("UI/Canvas/Package").GetComponent<UIPackageController>().LoadCharacterItem();
    }

    public void Close()
    {
        UIPackageController.isDisplay = false;
        Destroy(gameObject);
    }
}
