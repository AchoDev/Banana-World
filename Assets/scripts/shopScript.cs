using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopScript : MonoBehaviour
{
    public string itemName;
    public Button button;
    private ColorBlock greenColor;
    private ColorBlock normalColor;

    public void buyItem()
    {
        if (PlayerPrefs.GetInt(itemName) == 1)
        {
            PlayerPrefs.SetInt(itemName, 0);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt(itemName, 1);
            PlayerPrefs.Save();
        }
    }

    private void Start()
    {
        greenColor = button.colors;
        normalColor = button.colors;

        greenColor.normalColor = Color.green;
        normalColor.normalColor = Color.gray;

        greenColor.selectedColor = Color.green;
        normalColor.selectedColor = Color.gray;

        greenColor.highlightedColor = Color.green;
        normalColor.highlightedColor = Color.gray;

    }

    private void Update()
    {
        if(PlayerPrefs.GetInt(itemName) == 1)
        {
            button.colors = greenColor;
        }
        else
        {
            button.colors = normalColor;
        }
    }
}
