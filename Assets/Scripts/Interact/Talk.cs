using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : Interactable
{
   
    [SerializeField]
    D_Container container;
    public override void Interact(Character character)
    {
        GameManager.Instance.DialogueSystem.Init();
    }
}
