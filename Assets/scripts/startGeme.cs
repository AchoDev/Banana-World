using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGeme : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("coroutine");
        this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }
    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1.5f);

        for (float i = 0; i <= 1; i += 0.01f)
        {
            yield return new WaitForSeconds(0.01f);
            this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, i);
        }

        yield return new WaitForSeconds(1.5f);

        for (float i = 1; i >= 0; i -= 0.01f)
        {
            yield return new WaitForSeconds(0.01f);
            this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, i);
        }

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
