using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopReceive : MonoBehaviour
{
    public string itemName;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {


        if (PlayerPrefs.GetInt(itemName) == 1)
        {
            self.SetActive(true);
        } 
    }

}
