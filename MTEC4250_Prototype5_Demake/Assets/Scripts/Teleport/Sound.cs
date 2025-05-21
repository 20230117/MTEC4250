using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource Aud;
    // Start is called before the first frame update
    void Start()
    {
        Aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Play()
    {
        Aud.Play();
    }
}
