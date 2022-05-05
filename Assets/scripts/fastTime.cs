using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastTime : MonoBehaviour
{

    public float newTime;
    // Start is called before the first frame update
    void Update()
    {
        Time.timeScale = newTime;
    }
    // Update is called once per frame

}
