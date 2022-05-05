using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScriptUnder : MonoBehaviour
{
    public GameObject button;
    public GameObject firstDoor;

    public int doorLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
        firstDoor.GetComponent<doorScript>().currentLevel = doorLevel;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }
}
