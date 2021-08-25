using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseChange : Interactable
{

    [SerializeField]
    protected Image clothesImage;
    [SerializeField]
    protected Image playerImage;

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
    protected virtual void Change()
    {
        
    }
}
