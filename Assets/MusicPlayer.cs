using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void playMusic(AudioClip track)
    {
        audioSource.Stop();
        audioSource.clip = track;
        audioSource.Play();
    }
	
}
