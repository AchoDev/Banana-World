using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour
{

    public GameObject player;
    public Transform self;
    public Renderer meshR;

    public bool isFive = false;
    public bool isSpecial = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlackScreen()
    {
        this.GetComponent<Transform>().position = new Vector2(player.GetComponent<Transform>().position.x + 100, player.GetComponent<Transform>().position.y);
        self.position = new Vector3(self.position.x,self.position.y, -3000);

        this.GetComponent<MeshRenderer>().enabled = true;
        StartCoroutine(Courotine());

    }

     IEnumerator Courotine() 
    {

        for (int i = 0; i < 100; i++)
        {
            this.GetComponent<Transform>().position = new Vector3(self.position.x - 1, self.position.y, -100);
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(2);

        if (!isFive && !isSpecial)
        {
            SceneManager.LoadScene("overworld");
        }
        else if(isSpecial)
        {
            SceneManager.LoadScene("special");
        }
        else if(isFive)
        {
            SceneManager.LoadScene("sewers");
        }
    }

}
