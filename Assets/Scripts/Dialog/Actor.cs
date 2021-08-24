using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Dialogue/Actor")]
public class Actor : ScriptableObject
{
    [SerializeField]
    private string nameOfActor;
    [SerializeField]
    private Sprite image;
    [SerializeField]
    private bool hasOptions;
    public string Name { get => nameOfActor; private set => nameOfActor = value; }
    public Sprite Image { get => image;private set => image = value; }
    public bool HasOptions { get => hasOptions;private set => hasOptions = value; }
}
