
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   
    public void killApp()
    {
        Application.Quit();
        Debug.Log("Game is exiting");

    }
}
