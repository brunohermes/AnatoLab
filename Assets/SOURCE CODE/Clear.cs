using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameObject[] gameObjectArray;

    public void clear()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }
    }
}
