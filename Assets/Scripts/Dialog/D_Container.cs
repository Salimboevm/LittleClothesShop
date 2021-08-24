using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/Dialogue/Container")]
public class D_Container : ScriptableObject
{
    [SerializeField]
    private List<string> line;
    [SerializeField]
    private Actor actor;

    public List<string> Line { get => line;private set => line = value; }
    public Actor Actor { get => actor;private set => actor = value; }
}
