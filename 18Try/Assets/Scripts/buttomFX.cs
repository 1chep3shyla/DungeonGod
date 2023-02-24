using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttomFX : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void play()
    {
        float random = Random.Range(0.50f, 0.80f);
        audioSource.pitch = random;
        audioSource.PlayOneShot(clip);
        
    }
}
