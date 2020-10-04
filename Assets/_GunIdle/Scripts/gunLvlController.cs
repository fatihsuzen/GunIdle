using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunLvlController : MonoBehaviour
{
    public List<GameObject> gunLvl5EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl10EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl15EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl20EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl25EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl30EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl35EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl40EnableObject = new List<GameObject>();
    public List<GameObject> gunLvl45EnableObject = new List<GameObject>();
    public List<Button> gunLvlEnableButtons = new List<Button>();
    public int[] buttonLvlValue = { 5, 10, 15, 20, 25, 30, 35, 40, 45 };
    int i = 5;
    private void Start()
    {
        InvokeRepeating("LvlButtonActive", 0, 1);
    }
    void LvlButtonActive()
    {
            for(int x=0;x<gunLvlEnableButtons.Count;x++)
            {
                if (buttonLvlValue[x] <= Healthbar.GunLvlCounter)
                {
                    if (gunLvlEnableButtons[x].IsActive())
                     {
                    gunLvlEnableButtons[x].gameObject.SetActive(false);
                    GunLvlController();
                     }       
                }
                else
                {
                    gunLvlEnableButtons[x].interactable = false;
                }
            }
    }
    public void GunLvlController()
    {
        Invoke("GunLvl" + i +"EnableObject",0);
        i += 5;

    }
    public void GunLvl5EnableObject()
    {
        for(int i = 0;i<gunLvl5EnableObject.Count;i++)
        {
            gunLvl5EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl10EnableObject()
    {
        for (int i = 0; i < gunLvl10EnableObject.Count; i++)
        {
            gunLvl10EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl15EnableObject()
    {
        for (int i = 0; i < gunLvl15EnableObject.Count; i++)
        {
            gunLvl15EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl20EnableObject()
    {
        for (int i = 0; i < gunLvl20EnableObject.Count; i++)
        {
            gunLvl20EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl25EnableObject()
    {
        for (int i = 0; i < gunLvl25EnableObject.Count; i++)
        {
            gunLvl25EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl30EnableObject()
    {
        for (int i = 0; i < gunLvl30EnableObject.Count; i++)
        {
            gunLvl30EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl35EnableObject()
    {
        for (int i = 0; i < gunLvl35EnableObject.Count; i++)
        {
            gunLvl35EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl40EnableObject()
    {
        for (int i = 0; i < gunLvl40EnableObject.Count; i++)
        {
            gunLvl40EnableObject[i].SetActive(true);
        }
    }
    public void GunLvl45EnableObject()
    {
        for (int i = 0; i < gunLvl45EnableObject.Count; i++)
        {
            gunLvl45EnableObject[i].SetActive(true);
        }
    }
}
