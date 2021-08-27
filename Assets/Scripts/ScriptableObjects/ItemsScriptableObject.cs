using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class ItemImages
{
    
    [SerializeField]
    private Sprite items;
    public Item item;

    public Sprite Items { get => items; private set => items = value; }
    
}

[CreateAssetMenu(menuName ="Data/Clothes/Clothes")]
public class ItemsScriptableObject : ScriptableObject
{
    
    [SerializeField]
    private Sprite[] player;
    public ItemImages[] itemsImages;
    public Sprite[] Player { get => player;private set => player = value; }
}
