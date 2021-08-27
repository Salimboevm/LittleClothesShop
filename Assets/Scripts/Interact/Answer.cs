using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    [SerializeField]
    D_System d_System;
    [SerializeField]
    Inventory inventory;
    public void AnswerYes()
    {
        //EndDialogue();
        d_System.SetCurrent(1);
        d_System.LoopRead();
        
        //set value of inventor to buy and wear it
        //decrease money from inventory
        gameObject.SetActive(false);
    }
    public void AnswerNo()
    {
        //End dialogue
        //EndDialogue();
        d_System.SetCurrent(2);
        d_System.LoopRead();
        inventory.items.Clear();
        gameObject.SetActive(false);
        //set value of actor to not buy 
        //remove from inventor
    }
}
