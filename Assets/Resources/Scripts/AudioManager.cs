using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEditor;

public class AudioManager : MonoBehaviour
{

    public AudioClip jumpClip;
    public AudioClip dashClip;
    public AudioClip footstepSound;
    public AudioClip attackSound;
    public AudioClip backgroundMusic;

    private AudioSource soundEffectSource;
    private AudioSource backgroundMusicSource;
    public static AudioManager instance;
    
    // Start is called before the first frame update
    void Awake()
    {
      if(instance == null) 
      {
        instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else{
        Destroy(gameObject);
        return;
      }

      soundEffectSource = gameObject.AddComponent<AudioSource>();
      backgroundMusicSource = gameObject.AddComponent<AudioSource>();

      backgroundMusicSource.clip = backgroundMusic;
      backgroundMusicSource.loop = true;
      backgroundMusicSource.Play();
      
    }

    public void PlayJumpSound()
    {
        soundEffectSource.PlayOneShot(jumpClip);
        
    }

     public void PlayDashSound()
    {
        soundEffectSource.PlayOneShot(dashClip);
        
    }

     public void PlayFootstepSound()
    {
        soundEffectSource.PlayOneShot(footstepSound);
        
    }

     public void PlayAttackSound()
    {
        soundEffectSource.PlayOneShot(attackSound);
        
    }

    public void PlayBackgroundMusic()
    {
        if(!backgroundMusicSource.isPlaying)
        {
            backgroundMusicSource.Play();
        }
    }

    public void PauseBackgroundMusic()
    {
        backgroundMusicSource.Pause();
    }

    public void StopBackgroundMusic()
    {
        backgroundMusicSource.Stop();
    }

    public void SetBackgroundMusicVolume(float volume)
    {
        backgroundMusicSource.volume = volume;
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}
