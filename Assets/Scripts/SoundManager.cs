using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip disappearSound;
    static AudioSource audioSrc;

    void Start()
    {
        disappearSound = Resources.Load<AudioClip>("EXPLOSION");
        audioSrc = gameObject.GetComponent<AudioSource>();

    }


    public static void playObjectDisappearSound()
    {
        audioSrc.PlayOneShot(disappearSound);
    }


}


