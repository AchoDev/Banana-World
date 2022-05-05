using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isNick : MonoBehaviour
{

    public GameObject MusicManager;
    public AudioSource nickMusic;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("mask01") == 1)
        {
            MusicManager.GetComponent<AudioSource>().mute = true;
            if(nickMusic == null)
            {
                return;
            }
            else
            {
                nickMusic.Play();
            }
        }
    }

}
