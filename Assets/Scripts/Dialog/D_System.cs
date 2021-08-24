﻿using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class D_System : MonoBehaviour
{
    [SerializeField]
    private GameObject parent;
    [SerializeField]
    private Text target;//target text to show dialoge
    [SerializeField]
    private Text nameT;//name of the talking actor 
    [SerializeField]
    private GameObject buttons;
    [SerializeField]
    Image portrait;//image of talking actor
    

    [Range(0,1)]
    [SerializeField]
    private float visiblePercent;//how much percent of text is visible
    [SerializeField]
    private float perLetterTime = 0.05f;//letter timing

    float timeToType, currentTime;//text type effect
    string showLine = "";//current line to show

    protected D_Container current_D;//current dialogue container
    protected int currentLine;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartDialogue();
        }
        TypeEffect();
    }
    /// <summary>
    /// self explain
    /// </summary>
    private void TypeEffect()
    {
        if (visiblePercent >= 1f)//check visible
            return;
        currentTime += Time.deltaTime;//increase time in realtime
        visiblePercent = currentTime / timeToType;//get visible time
        visiblePercent = Mathf.Clamp(visiblePercent, 0,1f);//clamp visible percent
        UpdateText();//write down letters
    }
    /// <summary>
    /// Letter type 
    /// </summary>
    void UpdateText()
    {
        int letters = (int)(showLine.Length * visiblePercent);
        target.text = showLine.Substring(0, letters);
    }
    /// <summary>
    /// Update Actors Info
    /// </summary>
    void UpdateInfo()
    {
        //image and name update
        portrait.sprite = current_D.Line[currentLine].actor.Image;
        nameT.text = current_D.Line[currentLine].actor.Name;
    }
    /// <summary>
    /// Initiator for the dialogue
    /// </summary>
    public void StartDialogue()
    {
        if(visiblePercent < 1f)//check visible text percent
        {
            visiblePercent = 1f;
            UpdateText();
            return;
        }

        if(currentLine >= current_D.Line.Count)//check our dialogue is not done yet
        {//end dialogue
            EndDialogue();
        }
        else
        {//show dialogue
            LoopRead();
        }
    }
    /// <summary>
    /// Read all of the lines in dialogue
    /// </summary>
    void LoopRead()
    {
        //show dialogue text
        showLine = current_D.Line[currentLine].line;
     
        if(current_D.Line[currentLine].actor != null)//check actor
        {
            UpdateInfo();
        }
        //check if dialogue has any questions
        if(current_D.Line[currentLine].containsQuestions == true)
        {
            //show buttons
            buttons.SetActive(true);
        }
        timeToType = showLine.Length * perLetterTime;//set time to type 
        //set everything in to init value
        currentTime = 0f;
        visiblePercent = 0f;

        target.text = "";
        //increase current line
        currentLine += 1;
    }
    /// <summary>
    /// initiate dialogue 
    /// </summary>
    /// <param name="d_Container"></param>
    public void InitDialogue(D_Container d_Container)
    {
        Show(true);//activate gameobject
        current_D = d_Container;//get dialogue owner and container
        currentLine = 0;//set current line to zero
        UpdateInfo();//update actors info
        LoopRead();//start type effect
    }
    /// <summary>
    /// set game object visibility
    /// </summary>
    /// <param name="status"></param>
    public void Show(bool status)
    {
        parent.SetActive(status);
    }
    /// <summary>
    /// finish dialogue
    /// </summary>
    protected void EndDialogue()
    {
        Show(false);
        buttons.SetActive(false);
    }

}
