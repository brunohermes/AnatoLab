using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public void changescn(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
