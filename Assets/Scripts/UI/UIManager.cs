using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public static UIManager Instance { get=>instance; }
    private void Awake()
    {
        instance = this;
    }
    [SerializeField]
    private GameObject gamePanel;//panel 
    [SerializeField]
    private Text coin;//coins text to show to user
    [SerializeField]
    private GameObject pause;//pause panel

    public GameObject GamePanel
    {
        get
        {
            return gamePanel;
        }
        
    }

    public Text Coin { get => coin;private set => coin = value; }

    private void Start()
    {
        SetCoins(GameManager.Instance.Coins); 
    }
    /// <summary>
    /// set coins from outside of the class
    /// </summary>
    /// <param name="v"></param>
    public void SetCoins(int v)
    {
        coin.text = v.ToString();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanelSHow();
        }
    }
    private void PausePanelSHow()
    {
        pause.SetActive(!pause.activeSelf);
        print(!gameObject.activeSelf);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

