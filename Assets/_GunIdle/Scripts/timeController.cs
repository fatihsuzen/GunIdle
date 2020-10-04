using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeController : MonoBehaviour
{   int savedTime;
    int nowTime;
    int bonusHour;
    void Start()
    {        
        LoadBonusMoney();
        money.Money += bonusHour * 2000000;
        InvokeRepeating("SaveCurrentSceneTime", 0, 1);
    }
    public void SaveCurrentSceneTime()
    {
        savedTime = System.DateTime.Now.Hour;
        PlayerPrefs.SetInt("SavedTime", savedTime);
        PlayerPrefs.Save();
    }
    public void LoadBonusMoney()
    {
        if(PlayerPrefs.HasKey("SavedTime"))
        {
            nowTime = System.DateTime.Now.Hour;
            if (PlayerPrefs.GetInt("SavedTime") > nowTime)
            {
                int savedTimeForCalc = PlayerPrefs.GetInt("SavedTime");
                savedTimeForCalc = 24 - savedTimeForCalc;
                bonusHour = savedTimeForCalc + System.DateTime.Now.Hour;
            }
            else
            {
                bonusHour = System.DateTime.Now.Hour - PlayerPrefs.GetInt("SavedTime");
            }
        }
        
    }
}
