using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Button : MonoBehaviour
{

    public RPGTalk rpgtalk;

    void Start()
    {
        rpgtalk.OnMadeChoice += OnMadeChoice;
    }

    void OnMadeChoice(int questionID, int choiceID)
    {
        if (choiceID == 0)
        {
            Debug.Log("Choosed 1");
        }
        else
        {
            Debug.Log("Choosed 2");
        }
    }
}

