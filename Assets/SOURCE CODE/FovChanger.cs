using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FovChanger : MonoBehaviour
{
    public Camera myCamera;
    public Slider fovSlider;



    public void ChangeFov()
    {
        Camera.main.fieldOfView = fovSlider.value;
    }
    
}
