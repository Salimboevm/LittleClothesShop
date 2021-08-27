using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoes : ChooseChange
{
    int index = 0;//current index


    [SerializeField]
    private ItemsScriptableObject shoes;//scriptable obj 
    public override void Interact(Character character)
    {
        base.Interact(character);
        _UI.Set();//show 
    }

    /// <summary>
    /// change to next item in the list
    /// </summary>
    protected override void Change()
    {
        if (index >= 0 && index < 2)
        {
            if (index != 1)
            {
                index++;
                _UI.Increase();
                clothesImage.sprite = shoes.itemsImages[index].Items;
                playerImage.sprite = shoes.Player[index];
                coin.text = shoes.itemsImages[index].item.itemPrice.ToString();
            }
            else if (index == 1)
            {
                index = 0;
                _UI.Reset();
                clothesImage.sprite = shoes.itemsImages[index].Items;
                playerImage.sprite = shoes.Player[index];
                coin.text = shoes.itemsImages[index].item.itemPrice.ToString();
            }

        }
    }

}
