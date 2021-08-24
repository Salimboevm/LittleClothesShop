using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }


    private void Awake()
    {
        if(_instance!=this||_instance != null)
        {
            Destroy(gameObject);
        }
        _instance = this;
        DontDestroyOnLoad(_instance.gameObject);
    }
    [SerializeField]
    private D_System dialogueSystem;

    public D_System DialogueSystem { get => dialogueSystem;private set => dialogueSystem = value; }

}
