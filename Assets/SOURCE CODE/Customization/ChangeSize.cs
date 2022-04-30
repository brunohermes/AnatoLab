using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public Slider sliderObject;

    void Start()
    {
   
    }
    public void sizeChange()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("infoButtons");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(sliderObject.value, sliderObject.value);
        }
    }

}
