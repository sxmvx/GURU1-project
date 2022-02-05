using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    static AudioSource damageSound;
    public static AudioClip audioClip;
   
    void Start()
    {
        damageSound = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("damageSound");
    }

    
    public static void PlaySound()
    {
        damageSound.PlayOneShot(audioClip);
    }
}
