using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextLvl : MonoBehaviour
{
  public void nextLvlButtonFunc()
    {
        SceneManager.LoadScene(1);
    }
    public void BackLvlButtonFunc()
    {
        SceneManager.LoadScene(0);
    }
}
