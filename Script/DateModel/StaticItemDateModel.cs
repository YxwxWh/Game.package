using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public static class StaticItemDateModel
{
    public static List<ItemCompleteDate> ReadItemCompleteDate(List<RoleDate.Row> items)
    {
        //读取装备Json文件
        TextAsset ta = Resources.Load<TextAsset>("Json/Items");
        //解析静态表成并存在list
        List<ItemStaticDate> date = JsonMapper.ToObject<  List<ItemStaticDate>   >(ta.text);

        //存放合并后的完整数据
        List<ItemCompleteDate> final = new List<ItemCompleteDate>();

        for (int i = 0; i < items.Count; i++)
        {
            for (int j = 0; j < date.Count; j++)
            {
                if (items[i].ItemID==date[j].ItemID)
                {
                    ItemCompleteDate row = new ItemCompleteDate();
                    row.ItemID = date[j].ItemID;
                    row.Name = date[j].Name;
                    row.Icon = date[j].Icon;   
                    row.Color = date[j].Color;
                    row.Type = date[j].Type;
                    row.Price = date[j].Price;
                    row.Count = items[i].Count;

                    final.Add(row);
                    break;
                }
            }
        }

        return final;


    }


}
