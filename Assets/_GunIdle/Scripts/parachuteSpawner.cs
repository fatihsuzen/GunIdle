using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachuteSpawner : MonoBehaviour
{
    public GameObject parachute;
    void Start()
    {
        InvokeRepeating("SpawnParachute",60,60);
    }
    void SpawnParachute()
    {
        Instantiate(parachute, transform.position,Quaternion.Euler(-90,transform.rotation.y, transform.rotation.z));
    }
}
