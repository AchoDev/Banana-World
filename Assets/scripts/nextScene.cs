using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    public string SceneLoad;
    public int waitTime;

    private void Start()
    {
        StartCoroutine("TimeWait");
    }

    IEnumerator TimeWait()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneLoad);
    }
}
