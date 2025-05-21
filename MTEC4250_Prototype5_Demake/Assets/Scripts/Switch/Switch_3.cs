using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_3 : MonoBehaviour
{
    public GameObject Obstacle_01;
    public GameObject Obstacle_02;

    private bool AlreadySwitched;

    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (AlreadySwitched == false)
        {
            aud.Play();
            Obstacle_01.SetActive(true);
            Obstacle_02.SetActive(false);
            AlreadySwitched = true;
        }
        else
        {
            aud.Play();
            Obstacle_01.SetActive(false);
            Obstacle_02.SetActive(true);
            AlreadySwitched = false;
        }

    }
}
