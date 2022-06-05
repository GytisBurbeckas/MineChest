using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public static AudioClip digSound;
    public static AudioClip footsteps;
    public static AudioClip backGroundMusic;
    static AudioSource audioSource;
    public static bool isPlaying;
    public static bool isPlayingFootsteps;
    public AudioMixer audioMixer;
    
    // Start is called before the first frame update
    void Start()
    {
        digSound = Resources.Load<AudioClip>("digSound");
        footsteps = Resources.Load<AudioClip>("Footsteps");
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.isPlaying)
        {
            isPlaying = true;
        }
        else
        {
            isPlaying = false;
        }
    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "audioGarsas":
                if (!isPlaying)
                {
                    audioSource.PlayOneShot(digSound);
                }
                break;
            case "footsteps":
                if (!isPlaying)
                {
                    audioSource.PlayOneShot(footsteps);
                }
                break;
        }
    }


    //public void SetVolume(float volume)
    //{
    //  audioMixer.SetFloat("volume", volume);
    //float vol;
    //float temp;
    // volume yra tarp -80 ir 0 
    //temp = volume * (-1) / 80; // gauname tarp 0 - 1 0-> max 1-> lowest
    //if (temp - 0.5 > 0)
    //{
    //    vol = 
    //}
    //else
    // {
    //   vol = 
    // }

    //backgroundMusicSource.volume = 1;
    //}
}
