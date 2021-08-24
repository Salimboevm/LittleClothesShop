using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class D_Line
{
    public string line;
    public Actor actor;
    public bool containsQuestions;
}

[CreateAssetMenu(menuName = "Data/Dialogue/Container")]
public class D_Container : ScriptableObject
{
    [SerializeField]
    private List<D_Line> line;
    
    public List<D_Line> Line { get => line;private set => line = value; }
}
