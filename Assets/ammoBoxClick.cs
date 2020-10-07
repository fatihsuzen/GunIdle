using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoBoxClick : MonoBehaviour
{
    public GameObject panel;
    private void OnMouseDown()
    {
        Destroy(gameObject);
        panel.SetActive(true);
        money.Money += 5000000;
    }
}
