using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public void Transformup(float y)
    {
        if (transform.position.y < 2.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + y, transform.position.z);
        }
    }
    public void Transformdown(float y)
    {
        if(transform.position.y>-3f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - y, transform.position.z);
        }
        
    }
}
