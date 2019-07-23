using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPackageItemListView : MonoBehaviour
{

    public Transform ItemGrid;
    public InputField SerchText;

    private List<ItemCompleteDate> _Date;

    public void DisPlay(List<ItemCompleteDate> date)
    {
        _Date = date;

        Debug.Log(ItemGrid.childCount);
        ItemGrid.DeleteAllChild();
        
        for (int i = 0; i < date.Count; i++)
        {
            GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
            cell.GetComponent<UIPackageItemDateView>().DisPlay(date[i]);
        }

    }
    public void DisPlayAll()
    {        
        DisPlay(_Date);
    }

    public void DisPlayWeapon()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type==1)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void DisPlayArmour()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type == 2)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void DisPlayGuard()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type == 3)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void DisPlayNecklace()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type == 4)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void DisPlayHelmet()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type == 5)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void DisPlayShoes()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Type == 6)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void Serch()
    {
        ItemGrid.DeleteAllChild();
        for (int i = 0; i < _Date.Count; i++)
        {
            if (_Date[i].Name == SerchText.textComponent.text)
            {
                GameObject cell = Prefabs.Load("UI/Perfabs/ItemCell", ItemGrid);
                cell.GetComponent<UIPackageItemDateView>().DisPlay(_Date[i]);
            }
        }
    }

    public void ReomoveChildren()
    {
        Debug.Log(gameObject.transform.childCount);

    }
}
