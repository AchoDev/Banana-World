using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollect_ub : MonoBehaviour
{

    public GameObject self;
    public Transform selfT;
    public float counter = 10f;

    public bool isUnlimited = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selfT.Rotate(0, 0, 50 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        self.SetActive(false);

        isUnlimited = true;
        Invoke("stopUnlimited", counter);

    }

    private void stopUnlimited()
    {
        isUnlimited = false;
    }

}
