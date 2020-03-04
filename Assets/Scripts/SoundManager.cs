using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audio_source_0;
    AudioSource audio_source_1;
    AudioSource audio_source_2;
    AudioSource audio_source_3;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audio_sources = GetComponents<AudioSource>();
        audio_source_0 = audio_sources[0];
        audio_source_1 = audio_sources[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClickSound()
    {

    }
}
