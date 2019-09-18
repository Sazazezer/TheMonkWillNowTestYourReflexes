using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour {  

    public AudioClip[] audioClipCollection;
    public AudioClip audioClip;
    public int soundLastPlayed;
    AudioSource audioSource;
    public int test;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void Play()
    {
        test = Random.Range(0,3);
        Debug.Log(test);
        if(test==1){
                soundLastPlayed = Random.Range(0,audioClipCollection.Length);
            } else{
                soundLastPlayed = 1;
            }
        
        audioClip = audioClipCollection[soundLastPlayed];
        audioSource.PlayOneShot(audioClip, 0.7F);
    }

    public void ResetSound(){
        soundLastPlayed = -1;
    }
}
