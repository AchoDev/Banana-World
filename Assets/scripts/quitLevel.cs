using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitLevel : MonoBehaviour
{
    public void quitOverLevel()
    {
        SceneManager.LoadScene("main menu");
    }
}
