using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnActivation : MonoBehaviour
{
    public GameObject RespawnPoint;
    private AudioSource aud;

    private bool AlreadyActive;

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
        if (AlreadyActive == true && RespawnPoint.transform.position == this.transform.position)
        {

        }
        else
        {
            RespawnPoint.transform.position = this.transform.position;
            AlreadyActive = true;
            aud.Play();
        }
    }
}
