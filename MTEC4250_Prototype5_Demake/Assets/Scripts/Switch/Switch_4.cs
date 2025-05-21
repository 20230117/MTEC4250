using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_4 : MonoBehaviour
{
    public GameObject Obstacle_01;
    public GameObject Obstacle_02;

    private bool AlreadySwitched;

    AudioSource aud;
    // Start is called before the first frame update
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
            Obstacle_01.SetActive(false);
            Obstacle_02.SetActive(true);
            AlreadySwitched = true;
        }
        else
        {
            aud.Play();
            Obstacle_01.SetActive(true);
            Obstacle_02.SetActive(false);
            AlreadySwitched = false;
        }

    }
}
