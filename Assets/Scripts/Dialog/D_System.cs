using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class D_System : MonoBehaviour
{
    [SerializeField]
    private Text target;
    [SerializeField]
    private Text nameT;

    [Range(0,1)]
    [SerializeField]
    private float visiblePercent;
    [SerializeField]
    private float perLetterTime = 0.05f;

    float timeToType, currentTime;
    string showLine = "";

    D_Container current;
    int currentLine;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartDialogue();
        }
        TypeEffect();
    }
    private void TypeEffect()
    {
        if (visiblePercent >= 1f)
            return;
        currentTime += Time.deltaTime;
        visiblePercent = currentTime / timeToType;
        visiblePercent = Mathf.Clamp(visiblePercent, 0,1f);
        UpdateText();
    }

    void UpdateText()
    {
        int letters = (int)(showLine.Length * visiblePercent);
        target.text = showLine.Substring(0, letters);
    }

    public void StartDialogue()
    {
        if(visiblePercent < 1f)
        {
            visiblePercent = 1f;
            UpdateText();
            return;
        }

        if(currentLine >= current.Line.Count)
        {
            EndDialogue();
        }
        else
        {
            LoopRead();
        }
    }
    void LoopRead()
    {
        showLine = current.Line[currentLine];
        timeToType = showLine.Length * perLetterTime;
        currentTime = 0f;
        visiblePercent = 0f;

        target.text = "";
        print(currentLine);

        currentLine += 1;
        print(currentLine);
    }
    public void InitDialogue(D_Container d_Container)
    {
        Show(true);
        current = d_Container;
        currentLine = 0;
        LoopRead();
    }

    public void Show(bool status)
    {
        gameObject.SetActive(status);
    }
    public void EndDialogue()
    {
        Show(false);
    }

}
