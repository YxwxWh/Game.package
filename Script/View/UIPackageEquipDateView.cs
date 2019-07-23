using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class UIPackageEquipDateView : MonoBehaviour {

    public Image Icon;
    public int Type;


    public void DisPlay(List<EquipDate> date, List<ItemCompleteDate> completedate)
    {

        
        for (int i = 0; i < date.Count; i++)
        {
            for (int j = 0; j < completedate.Count; j++)
            {
                if (date[i].ItemID == completedate[j].ItemID && completedate[j].Type == Type&&completedate[j].Count>0)
                {
                    string[] IconDate = completedate[j].Icon.Split('#');             
                    SpriteAtlas IconAtlas = Resources.Load<SpriteAtlas>("UI/" + IconDate[0]);
                   
                    Icon.sprite = IconAtlas.GetSprite(IconDate[1]);
                    //Debug.Log("UI/" + IconDate[1]);
                    //Debug.Log(Icon.sprite.name);
                    return;
                }
                else
                {
                    Icon.sprite = Resources.Load<Sprite>("UI/Farme/package_equip_bg");
                }
            }
        }
        



    }



}
