using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelController : MonoBehaviour
{   
    public TextMeshProUGUI lvlText;
    Button button;
    public int lvlCounter=1;
    public static int LvlCounter;
    public string buttonName;
    private void Start()
    {
        lvlCounter = PlayerPrefs.GetInt(buttonName + "lvlCounter");
        LvlCounter = lvlCounter;
        button = GetComponent<Button>();
        lvlText.text = "lvl " + lvlCounter;
    }
    public void LvlContrller()
    {  
        if (lvlCounter >= 90)
        {
            button.gameObject.SetActive(false);           
        }
        else
        {
            lvlCounter++;
            LvlCounter = lvlCounter;
            lvlText.text = "lvl " + lvlCounter;
        }
        SaveLevel();
    }
    public void SaveLevel()
    {
        PlayerPrefs.SetInt(buttonName + "lvlCounter", lvlCounter);
    }
}
