using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockGeneratorBtn : MonoBehaviour
{
    public AudioSource SoundFX;
    public AudioClip voice30;
    public AudioClip voice60;


    public void Shock_30()
    {
        SoundFX.PlayOneShot(voice30);
    }

    public void Shock_60()
    {
        SoundFX.PlayOneShot(voice60);
    }
}
