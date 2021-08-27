using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField]
    CharacterController characterController;//current cc
    [SerializeField]
    private Item[] items;//list of items
    private int index = 0;//current index to see items 
 
    [SerializeField]
    private int whichOne;
    /// <summary>
    /// set our show menu
    /// </summary>
    public void Set()
    {
        gameObject.SetActive(true);
        characterController.SetCanMove(false);
        UIManager.Instance.GamePanel.SetActive(false);
    }
    /// <summary>
    /// func to call from button
    /// deactivate our show menu
    /// </summary>
    public void Deactivate()
    {
        gameObject.SetActive(false);
        characterController.SetCanMove(true);
        UIManager.Instance.GamePanel.SetActive(true);
    }
    /// <summary>
    /// func to add items to our inventory list of items 
    /// </summary>
    void Add()
    {
        Inventory.instance.Add(items[index]);
    }
    public int Increase() => index++;//increase index to see next item in the list
    public int Reset() => index = 0;//reset index
}
