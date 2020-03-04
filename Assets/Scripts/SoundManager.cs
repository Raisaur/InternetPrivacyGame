using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audio_source_0; //Click sound
    AudioSource audio_source_1; //HoverButton sound
    AudioSource audio_source_2; //Getting Upgrade
    AudioSource audio_source_3; //Getting lots of money
    AudioSource audio_source_4; //Getting a little money
    AudioSource audio_source_5; //Getting no money

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audio_sources = GetComponents<AudioSource>();
        audio_source_0 = audio_sources[0];
        audio_source_1 = audio_sources[1];
        audio_source_2 = audio_sources[2];
        audio_source_3 = audio_sources[3];
        audio_source_4 = audio_sources[4];
        audio_source_5 = audio_sources[5];
    }

    public void PlayClickSound()
    {
        audio_source_0.Play();
    }

    public void PlayHoverButton()
    {
        audio_source_1.Play();
    }

    public void PlayUpgradeSound()
    {
        audio_source_2.Play();
    }

    public void PlayLotsOfMoneySound()
    {
        audio_source_3.Play();
    }

    public void PlayLittleMoneySound()
    {
        audio_source_4.Play();
    }

    public void PlayNoMoneySound()
    {
        audio_source_5.Play();
    }
}
