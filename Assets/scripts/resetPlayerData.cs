using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayerData : MonoBehaviour
{
  public void resetData()
    {
        PlayerPrefs.SetInt("mask01Collected", 0);
        PlayerPrefs.SetInt("mask01", 0);
        PlayerPrefs.SetInt("tshirt01", 0);
        PlayerPrefs.SetInt("hair01", 0);
        PlayerPrefs.SetInt("glasses01", 0);
    }
}
