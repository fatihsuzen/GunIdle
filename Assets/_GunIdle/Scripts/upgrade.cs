using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class upgrade : MonoBehaviour
{
    public bulletSpawner bulletSpawner;
    public TextMeshProUGUI moneyButtonText;
    public TextMeshProUGUI bulletTimeText;  
    public TextMeshProUGUI moneyTargetText; 
    public float currentMoneyValue=10;
    public float currentMoneyPrice = 10;
    public float multiplier;
    public string saveName;
    public int gunNo;
    public void Start()
    {
        LoadGame();
        bulletMoneyEvent.BuletValue[gunNo] = (int)currentMoneyValue;
        moneyButtonText.text = (int)currentMoneyPrice + "";
        moneyTargetText.text = (int)currentMoneyValue + "$";
        bulletTimeText.text = Math.Round(60/bulletSpawner.AutoFireTime, 1) + "/MIN";
    }   
    public void UpgradeMoneyButtonFucn(int gunArrayNO)
    {
        money.Money -= (int)currentMoneyPrice;
        if (levelController.LvlCounter>20)
        {
            currentMoneyValue += 50 * multiplier;
            currentMoneyPrice += 1000 * multiplier;
        }        
        else
        {
            currentMoneyValue += 2 * multiplier;
            currentMoneyPrice += 5 * multiplier;
        }
        if (bulletSpawner.AutoFireTime > 0.2f)
        {
            bulletSpawner.AutoFireTime -= 0.02f;
        }
        bulletMoneyEvent.BuletValue[gunArrayNO] = (int)currentMoneyValue;
        moneyButtonText.text = (int)currentMoneyPrice + "";
        moneyTargetText.text = (int)currentMoneyValue + "$";
        bulletTimeText.text = Math.Round(60 / bulletSpawner.AutoFireTime, 1) + "/MIN";
        multiplier += 0.1f;
        SaveName();
    }
    public void SaveName()
    {
        PlayerPrefs.SetFloat(saveName + "currentMoneyValue", currentMoneyValue);
        PlayerPrefs.SetFloat(saveName + "currentMoneyPrice", currentMoneyPrice);
        PlayerPrefs.SetFloat(saveName + "multiplier", multiplier);
        PlayerPrefs.SetFloat(saveName + "AutoFireTime", bulletSpawner.AutoFireTime);
    }
    public void LoadGame()
    {        
        currentMoneyValue = PlayerPrefs.GetFloat(saveName + "currentMoneyValue");    
        currentMoneyPrice = PlayerPrefs.GetFloat(saveName + "currentMoneyPrice");        
        if (PlayerPrefs.HasKey(saveName + "multiplier"))
        {
            multiplier = PlayerPrefs.GetFloat(saveName + "multiplier");
        }
        if (PlayerPrefs.HasKey(saveName + "AutoFireTime"))
        {
            bulletSpawner.AutoFireTime = PlayerPrefs.GetFloat(saveName + "AutoFireTime");
        }       
        moneyButtonText.text = (int)currentMoneyPrice + "";
    }
}
