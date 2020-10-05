using System.Collections;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float AutoFireTime=2f;
    AudioSource fireSound;
    Animator fireAnimation;
    public ParticleSystem particleSystem;
    void Start()
    {
        fireSound = GetComponent<AudioSource>();
        fireAnimation = GetComponent<Animator>();
        StartCoroutine(CoroutineTest());
    }
    IEnumerator CoroutineTest()
    {        
        yield return new WaitForSeconds(AutoFireTime);
        fireAnimation.Play(0, 0, 0.25f);
        particleSystem.Play();
        Instantiate(bullet, transform.position, Quaternion.Euler(-90f, 0, -90f));
        StartCoroutine(CoroutineTest());
    }
    public void FireButtonFunc()
    {
        //fireSound.Play();
        Instantiate(bullet, transform.position, Quaternion.Euler(-90f, 0, -90f));
    }
}
