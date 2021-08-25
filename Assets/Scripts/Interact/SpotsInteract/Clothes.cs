using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clothes : ChooseChange
{
    int index = 0;

    [SerializeField]
    private Activator uI;



    [SerializeField]
    private HatsScriptableObject hatsScriptable;

    public override void Interact(Character character)
    {
        base.Interact(character);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Change();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Change();
        }
    }
    protected override void Change()
    {
        if (index > 0)
        {
            index--;
            clothesImage.sprite = hatsScriptable.Hats[index];
            playerImage.sprite = hatsScriptable.Player[index];
        }
        else
        {
            index = 2;
            clothesImage.sprite = hatsScriptable.Hats[index];
            playerImage.sprite = hatsScriptable.Player[index];
        }
    }
}
