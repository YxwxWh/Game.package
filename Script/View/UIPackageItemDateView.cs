using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class UIPackageItemDateView : MonoBehaviour
{
    public ItemCompleteDate _Date;

    public Image Icon;
    public Image Frame;
    public Text Count;


    public void DisPlay(ItemCompleteDate date)
    {
        

        _Date=  date;

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

        Count.text = date.Count.ToString();

    }
















}
