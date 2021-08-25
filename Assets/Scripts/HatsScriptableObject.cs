using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="Data/Clothes/Hats")]
public class HatsScriptableObject : ScriptableObject
{
    [SerializeField]
    private Sprite[] hats;
    [SerializeField]
    private Sprite[] player;

    public Sprite[] Hats { get => hats;private set => hats = value; }
    public Sprite[] Player { get => player;private set => player = value; }
}
