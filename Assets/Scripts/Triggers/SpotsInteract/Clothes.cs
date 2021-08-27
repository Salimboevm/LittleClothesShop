using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clothes : ChooseChange
{
    int index = 0;//current index
    [SerializeField]
    private ItemsScriptableObject clothes;//clothes items scriptable obj

    public override void Interact(Character character)
    {
        base.Interact(character);
        _UI.Set();
    }
    /// <summary>
    /// change current item sprite to other one to see which item is now current
    /// </summary>
    protected override void Change()
    {
        if (index >= 0 && index < 3)
        {
            if (index != 2)
            {
                index++;
                _UI.Increase();
                clothesImage.sprite = clothes.itemsImages[index].Items;
                playerImage.sprite = clothes.Player[index];
                coin.text = clothes.itemsImages[index].item.itemPrice.ToString();

            }
            else if (index == 2)
            {
                index = 0;
                _UI.Reset();
                clothesImage.sprite = clothes.itemsImages[index].Items;
                playerImage.sprite = clothes.Player[index];
                coin.text = clothes.itemsImages[index].item.itemPrice.ToString();
            }

        }
    }
}
