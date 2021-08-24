using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : D_System
{
    public void AnswerYes()
    {
        EndDialogue();
        //set value of inventor to buy and wear it
        //decrease money from inventory
        
    }
    public void AnswerNo()
    {
        //End dialogue
        EndDialogue();
        //set value of actor to not buy 
        //remove from inventor
    }
}
