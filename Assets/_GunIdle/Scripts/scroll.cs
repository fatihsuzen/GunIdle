using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public void Transformup(float y)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y+y, transform.position.z);
    }
    public void Transformdown(float y)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - y, transform.position.z);
    }
}
