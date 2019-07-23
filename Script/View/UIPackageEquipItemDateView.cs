using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPackageEquipItemDateView : MonoBehaviour {

    public List<UIPackageEquipDateView> Equip;

    public void DisPlay(List<EquipDate> date, List<ItemCompleteDate> completedate)
    {

        for (int i = 0; i < date.Count; i++)
        {
            switch (date[i].Type)
            {
                case 1:
                    Equip[0].DisPlay(date,completedate);
                    break;

                case 2:
                    Equip[1].DisPlay(date, completedate);
                    break;

                case 3:
                    Equip[2].DisPlay(date, completedate);
                    break;

                case 4:
                    Equip[3].DisPlay(date, completedate);
                    break;

                case 5:
                    Equip[4].DisPlay(date, completedate);
                    break;

                case 6:
                    Equip[5].DisPlay(date, completedate);
                    break;

                default:
                    break;
            }
        }


    }
}
