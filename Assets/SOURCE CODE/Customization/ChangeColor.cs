using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] gameObjectArray;

    public void changecolorRed()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.red;
        }
    }
    public void changecolorBlue()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.blue;
        }
    }
    public void changecolorYellow()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.yellow;
        }
    }
    public void changecolorCyan()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.cyan;
        }
    }
    public void changecolorWhite()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.white;
        }
    }

    public void changecolorMagenta()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().color = Color.magenta;
        }
    }

  
}
