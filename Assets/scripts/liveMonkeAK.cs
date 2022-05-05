using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class liveMonkeAK : MonoBehaviour
{

    public TextMeshPro text;
    public GameObject monky;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = monky.GetComponent<shooting>().reloadTime.ToString();
    }
}
