using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adsManager : MonoBehaviour
{

   /** void Start()
    {
        Advertisement.Initialize("4275325");
        ShowBanner();
    }


    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner_Android"))
        {
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            Advertisement.Banner.Show("Banner_Android");
        }
        else
        {
            StartCoroutine(RepeatShowBanner());
        }

        IEnumerator RepeatShowBanner()
        {
            yield return new WaitForSeconds(1);
            ShowBanner();
        }
    }

    public void killBanner()
    {


    }
**/
}
