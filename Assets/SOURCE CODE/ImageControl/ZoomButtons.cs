using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomButtons : MonoBehaviour
{
    public GameObject YourPanel;
   
    public void ZoomIn()
    {
        YourPanel.GetComponent<RectTransform>().localScale = new Vector3(0.12f, 0.15f, 1f) *2;
    }
    public void ZoomOut()
    {
        YourPanel.GetComponent<RectTransform>().localScale = new Vector3(0.12f, 0.15f, 1f) / 2;
    }
    public void ZoomReset()
    {
        YourPanel.GetComponent<RectTransform>().localScale = new Vector3(0.12f, 0.15f, 1f);
    }
}
