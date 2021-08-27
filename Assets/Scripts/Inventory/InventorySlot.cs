using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    Item item;
    [SerializeField]
    Image icon;

    public void AddItem(Item item)
    {
        this.item = item;
        for (int i = 0; i < item.icon.Length; i++)
        {
            icon.sprite = item.icon[i];
        }
        icon.enabled = true;
    }

    public void Clear()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }
}
