using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame(bool isNewGame)
    {
        if (isNewGame)
        {
            PlayerPrefs.SetInt("currentLevelID", 0);
        }

        if (PlayerPrefs.GetInt("currentLevelID") > 0)
        {
            SceneManager.LoadScene("overworld");
        }
        else
        {
            SceneManager.LoadScene("Cutscene01");
        }
    }
}
