using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject MainScreen;
    public GameObject StartScreen;


    public void StartGame()
    {
        MainScreen.SetActive(true);
        StartScreen.SetActive(false);
    }


}
