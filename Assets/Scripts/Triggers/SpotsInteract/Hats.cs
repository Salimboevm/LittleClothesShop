using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hats : ChooseChange
{
    int index = 0;//current index


    [SerializeField]
    private ItemsScriptableObject hatsScriptable;//scriptable object of hats
    public override void Interact(Character character)
    {
        base.Interact(character);
        _UI.Set();//show

    }

    /// <summary>
    /// change to next item image 
    /// </summary>
    protected override void Change()
    {
        if (index >= 0 && index < 3)
        {
            if (index != 2)
            {
                index++;
                _UI.Increase();
                clothesImage.sprite = hatsScriptable.itemsImages[index].Items;
                playerImage.sprite = hatsScriptable.Player[index];
                coin.text = hatsScriptable.itemsImages[index].item.itemPrice.ToString();
            }else if(index == 2)
            {
                index = 0;
                _UI.Reset();
                clothesImage.sprite = hatsScriptable.itemsImages[index].Items;
                playerImage.sprite = hatsScriptable.Player[index];
                coin.text = hatsScriptable.itemsImages[index].item.itemPrice.ToString();
            }

        }
    }
    
}
