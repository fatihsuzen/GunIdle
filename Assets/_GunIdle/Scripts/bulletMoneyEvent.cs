using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class bulletMoneyEvent : MonoBehaviour
{
    public static int[] BuletValue = new int[11];
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "pistolTarget")
        {
            money.Money += BuletValue[0];
        }
        if (collision.collider.tag == "ak-47Target")
        {
            money.Money += BuletValue[1];
        }
        if (collision.collider.tag == "benelli_m4Target")
        {
            money.Money += BuletValue[3];
        }
        if (collision.collider.tag == "uziTarget")
        {
            money.Money += BuletValue[4];
        }
        if (collision.collider.tag == "M4_8Target")
        {
            money.Money += BuletValue[5];
        }
        if (collision.collider.tag == "M249Target")
        {
            money.Money += BuletValue[6];
        }
        if (collision.collider.tag == "m107Target")
        {
            money.Money += BuletValue[7];
        }
        if (collision.collider.tag == "m2_50Target")
        {
            money.Money += BuletValue[8];
        }
        if (collision.collider.tag == "RDG-5Target")
        {
            money.Money += BuletValue[9];
        }
        if (collision.collider.tag == "RPG7Target")
        {
            money.Money += BuletValue[10];
        }
        Destroy(gameObject);
        Healthbar.health += 2f;
    }

}
