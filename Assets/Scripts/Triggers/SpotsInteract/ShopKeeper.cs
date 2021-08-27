using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : ChooseChange
{
    [SerializeField]
    Interactable interct;
    [SerializeField]
    GameObject ui;
    public override void Interact(Character character)
    {
        base.Interact(character);
        interct.Interact(character);
        ui.SetActive(false);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
    public void Reset()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
