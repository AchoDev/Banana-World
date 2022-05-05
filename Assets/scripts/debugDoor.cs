using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class debugDoor : MonoBehaviour
{

    public GameObject doorint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshPro>().text = doorint.GetComponent<doorScript>().currentLevel.ToString();
    }
}
