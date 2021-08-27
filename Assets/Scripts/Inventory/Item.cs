using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Data/Clothes/Items")]
public class Item : ScriptableObject
{
    public string nameOfItem;//self described
    public Sprite[] icon;//image of our item
    public int whichOne;//which one is the item head, body, shoes
    public int itemPrice;//price of our item
    
}
