using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TestMusicTrigger : MonoBehaviour
{
    //public GameObject pobj;
    //public GameObject gobj;
    //public GameObject preF;
    public AudioClip clip;
    public AudioClip GravityUp;
    public AudioClip GravityDown;
    public AudioSource GameplaySound;
    bool isGravityUp = false;

    void OnStart()
    {
        GameplaySound = GetComponent<AudioSource>();
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameplaySound.PlayOneShot(clip, 0.1f);
        Debug.Log("Sound");
    }
    
    public void gravToggle()
    {
        isGravityUp = !isGravityUp;
    }

    public void upSound()
    {
        GameplaySound.PlayOneShot(GravityUp, 1f);
        gravToggle();
    }

    public void downSound()
    {
        GameplaySound.PlayOneShot(GravityDown, 1f);
        gravToggle();
    }

    public void playSound()
    {
        if (isGravityUp)
        {
            upSound();
        } else if (!isGravityUp)
        {
            downSound();
        }
                  
    }
}
