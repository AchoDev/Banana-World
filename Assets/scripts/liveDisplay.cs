﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class liveDisplay : MonoBehaviour
{

    public TextMeshProUGUI text;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.GetComponent<movement>().jumpsCount.ToString();
    }
}
