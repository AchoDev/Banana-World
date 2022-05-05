using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkUnlocked : MonoBehaviour
{
    public GameObject mask01;
    public bool isChecked;

    private void Update()
    {
        if (isChecked == true)
        {
            if (PlayerPrefs.GetInt("mask01Collected") == 1)
            {
                mask01.SetActive(true);
            }
            else
            {
                mask01.SetActive(false);
            }
        }
    }
}
