using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_content : MonoBehaviour
{
    public GameObject[] gameObjectArray;

    public void clearcontent()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Content");

        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }
    }
}
