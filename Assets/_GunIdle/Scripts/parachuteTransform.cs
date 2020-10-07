using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class parachuteTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(-4f,35f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
