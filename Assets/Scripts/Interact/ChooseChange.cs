using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseChange : Interactable
{

    [SerializeField]
    protected Image clothesImage;//image of outfits
    [SerializeField]
    protected Image playerImage;//what player will wear
    [SerializeField]
    protected Text coin;//price
    [SerializeField]
    protected Activator _UI;//activator ui to see 
    public override void Interact(Character character)
    {
        base.Interact(character);
    }

    private void Update()
    {
        //change to another outfit
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Change();
        }
    }
    protected virtual void Change()
    {
        
    }
}
