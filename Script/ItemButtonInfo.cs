using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemButtonInfo : MonoBehaviour,IPointerClickHandler {

    public ItemCompleteDate _Date;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!UIPackageController.isDisplay) 
        {
            GameObject go = Prefabs.Load("UI/Perfabs/ItemInfo", gameObject.transform.parent.parent);
            (go.transform as RectTransform).anchoredPosition = new Vector2(0, 0);
            UIPackageItemInfoView info = go.GetComponent<UIPackageItemInfoView>();
            info.DisPlay(_Date);
            UIPackageController.isDisplay = true;
        }
    }

    void Start () {
        _Date = this.GetComponent<UIPackageItemDateView>()._Date;
	}

   
}
