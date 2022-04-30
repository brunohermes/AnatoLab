using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    Image fillImg;
    float timeAmt = 10;
    float time;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
        }else if(time == 0 || time < 0)
        {
            SceneManager.LoadScene("3D_ENV", LoadSceneMode.Single);
            
        }
    }


}
