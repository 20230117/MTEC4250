using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameManager gameManager;

    public AudioSource source_collision;
    public AudioSource source_footsteps;
    public AudioSource source_exit;
    
    public AudioClip wallCollision;
    public AudioClip footsteps;
    public AudioClip exit;

    public bool soundAlreadyPlayed = false;
    public bool exitSoundAlreadyPlayed = false;
    
    void Start()
    {
        source_collision.volume = 0.25f;
        source_footsteps.volume = 0.3f;
        source_footsteps.loop = true;
        source_exit.loop = true;
    }

    void Update()
    {
        // ****** Footstep sound ******

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (soundAlreadyPlayed == false)
            {
                source_footsteps.Play();
                soundAlreadyPlayed = true;
            }
            else
            {

            }
        }
        else
        {
            source_footsteps.Stop();
            soundAlreadyPlayed = false;
        }

        // ****** Footstep sound ******

        // ****** Exit sound ******

        //source_exit.volume = 0.2f + (1f / gameManager.distance) * 1.5f;

        if (gameManager.distance < 15.0f)
        {
            if (exitSoundAlreadyPlayed == false)
            {
                source_exit.Play();
                exitSoundAlreadyPlayed = true;
            }
        }
        else
        {
            source_exit.Stop();
            exitSoundAlreadyPlayed = false;
        }

        // ****** Exit sound ******
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            source_collision.PlayOneShot(wallCollision);
        }
    }
}
