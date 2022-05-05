using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{

    public bool isMobile;
    //public GameObject joystick, jumpButton;
    public void setNewGame()
    {
        PlayerPrefs.SetInt("currentLevelID", 1);
        if (isMobile)
        {
            //joystick.SetActive(true);
            //jumpButton.SetActive(true);
        }
    }
    public void exitToOverworld()
    {
        SceneManager.LoadScene("overworld");
    }
}
