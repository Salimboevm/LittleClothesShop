using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    public delegate void OnItemChanged();//delegate to call when item changes
    public OnItemChanged onItemChanged;//event

    public List<Item> items;//list of our choosen items
    /// <summary>
    /// func to call from outside of the class
    /// to add items into our list
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Add(Item item)
    {
        items.Add(item);
        onItemChanged.Invoke();
        return true;
    }

}
