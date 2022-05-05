using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject button;
    public int currentLevel;
    public int currentLevelSet = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
        currentLevel = currentLevelSet;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }
}
