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
        //if(_instance!=this||_instance != null)
        //{
        //    Destroy(gameObject);
        //}
        _instance = this;
        //DontDestroyOnLoad(_instance.gameObject);
    }
    [SerializeField]
    private D_System dialogueSystem;//current set dialogue system 
    private int coins = 100;//num of coins

    public D_System DialogueSystem { get => dialogueSystem;private set => dialogueSystem = value; }
    public int Coins { get => coins;private set => coins = value; }
    public void SetCoins(int v) => coins -= v;//func to set coins
}
