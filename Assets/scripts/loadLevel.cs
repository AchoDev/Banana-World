using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public GameObject buttonInt;

    public void levelLoad()
    {
        SceneManager.LoadScene(buttonInt.GetComponent<doorScript>().currentLevel);
    }
}
