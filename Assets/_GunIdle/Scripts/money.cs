using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class money : MonoBehaviour
{
    public static long Money=0;
    public TextMeshProUGUI moneyText;
    int lvlBonus=50000;
    void Start()
    {        
        InvokeRepeating("MoneyUpdate", 0, 0.2f);
        LoadMoney();
    }
    public void MoneyUpdate()
    {
        moneyText.text = Money.ToString()+"$";
        SaveMoney();
    }
    public void SetMoneyValue(int value)
    {
        Money += value;
        SaveMoney();
    }
    public void LvlBonusMoney()
    {
        Money += lvlBonus;
        lvlBonus += lvlBonus/2;
        if (Money < 0)
        {
            Money *= -1;
        }
        SaveMoney();
    }
    public void SaveMoney()
    {
        PlayerPrefs.SetInt("Money",(int)Money); 
    }   
    public void LoadMoney()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            Money = PlayerPrefs.GetInt("Money");
        } 
    }
}
