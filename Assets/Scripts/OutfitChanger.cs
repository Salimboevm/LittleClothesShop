using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprites to change")]
    [SerializeField]
    private SpriteRenderer bodyPart;//body part of outfit
    [SerializeField]
    private SpriteRenderer headPart;//head part of outfit
    [SerializeField]
    private SpriteRenderer[] legsPart;//legs part of outfit
    [SerializeField]
    Inventory inventory;
    [SerializeField]
    InventoryUI inventoryUI;

    public void Apply()
    {

        for (int i = 0; i < inventory.items.Count; i++)//loop through items from invenotry
        {
            switch (inventory.items[i].whichOne)//check which one is it
            {
                
                case 0:
                    headPart.sprite = inventory.items[i].icon[0];//outfit changing
                    GameManager.Instance.SetCoins(inventory.items[i].itemPrice);//reduce num of coins
                    break;
                case 1:
                    bodyPart.sprite = inventory.items[i].icon[0];//outfit changing
                    GameManager.Instance.SetCoins(inventory.items[i].itemPrice);//reduce num of coins

                    break;
                case 2:
                    legsPart[0].sprite = inventory.items[i].icon[0];//outfit changing
                    legsPart[1].sprite = inventory.items[i].icon[1];//outfit changing
                    GameManager.Instance.SetCoins(inventory.items[i].itemPrice);//reduce num of coins
                    break;
                default: 
                    break;
            }
        }
        UIManager.Instance.SetCoins(GameManager.Instance.Coins);//set coins to show to user
        inventoryUI.Clear();
        inventory.items.Clear();
    }
}
