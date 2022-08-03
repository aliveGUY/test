using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;

public class DialoqueEnchanged : MonoBehaviour
{
    public DialogueNode[] node;
    public int _currentNode;
    public bool ShowDialogue = false;
    public int CountDialoque = 0;
    public GUISkin skin;
    public bool TriggerEnter = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && TriggerEnter == true)
        { ShowDialogue = true; }
    }


    private void OnTriggerEnter(Collider other)
    {
        TriggerEnter = true;
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerEnter = false;
    }

    private void DialogActive()
    {
      
    }


    void OnGUI()
    {

        GUI.skin = skin;
        //if (Input.GetMouseButtonDown(0))
        //{

        //    ShowDialogue = true;

        //}


        if (ShowDialogue == true)
        {
            var a = node[_currentNode].NpcText.GetParsedText();
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height - 300, 600, 250), "");
            GUI.Label(new Rect(Screen.width / 2 - 250, Screen.height - 280, 500, 90), a.ToString());

            if (CountDialoque >= 1)
            {
                _currentNode = node.Length - 1;
                var b = node[_currentNode].PlayerAnswer[0].text.GetParsedText();
                if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height - 200 + 25 * 0, 500, 25), b.ToString()))
                {
                    if (node[_currentNode].PlayerAnswer[0].SpeakEnd)
                    {

                        ShowDialogue = false;
                    }
                }
            }

            for (int i = 0; i < node[_currentNode].PlayerAnswer.Length; i++)
            {
                var c = node[_currentNode].PlayerAnswer[i].text.GetParsedText();
                if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height - 200 + 25 * i, 500, 25), c.ToString()))
                {
                    if (node[_currentNode].PlayerAnswer[i].SpeakEnd)
                    {

                        ShowDialogue = false;
                        CountDialoque++;
                    }
                    _currentNode = node[_currentNode].PlayerAnswer[i].ToNode;
                }
            }



        }
    }
}
[System.Serializable]
public class DialogueNode
{   
    public TextMeshProUGUI NpcText;
    public Answer[] PlayerAnswer;
}


[System.Serializable]
public class Answer
{
    public TextMeshProUGUI text; // public string Text;
    public int ToNode;
    public bool SpeakEnd;
}