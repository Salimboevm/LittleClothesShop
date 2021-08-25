using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject displayPanel;
    [SerializeField]
    private CharacterInteract ch_interact;

    //catch when player enters to trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            //show interact button 
            displayPanel.SetActive(true);

            //if player presses e 
            //interact 
            //only inside the trigger 
            ch_interact.SetCanInteract(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            displayPanel.SetActive(false);

            ch_interact.SetCanInteract(false);
        }
    }

}
