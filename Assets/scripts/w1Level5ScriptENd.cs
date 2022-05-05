using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w1Level5ScriptENd : MonoBehaviour
{
    public GameObject EndButton;
    public bool isSpecial = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isSpecial == false)
        {
            EndButton.SetActive(true);
        }
        else
        {
            if(PlayerPrefs.GetInt("hair01") == 1)
            {
                EndButton.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EndButton.SetActive(false);
    }
}
