using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class buttonController : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();
    public List<TextMeshProUGUI> texts = new List<TextMeshProUGUI>();
    public Button lvlUpButton;
    public Button nextLvlButton;
    void Start()
    {
        InvokeRepeating("ButtonControl", 0, 0.1f);
    }
    public void ButtonControl()
    {
        for(int i = 0; i<buttons.Count;i++)
        { 
            if (int.Parse(texts[i].text) > money.Money)
            {
                buttons[i].interactable = false;
            }
            else
            {
                buttons[i].interactable = true;
            }
        }
        if(Healthbar.health>=Healthbar.maximumHealth)
        {
            lvlUpButton.interactable = true;
        }
        else
        {
            lvlUpButton.interactable = false;
        }
        if(levelController.LvlCounter>=25)
        { 
            nextLvlButton.interactable = true;
        }
        else
        {
            nextLvlButton.interactable = false;
        }
    }
}
