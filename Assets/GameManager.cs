using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public AudioClip track;
    public GameObject musicPrefab;
    public float volume;

    private GameObject music;

    // Use this for initialization
    void Start () {
        music = GameObject.FindWithTag("music");
        if (music == null)
        {
            music = GameObject.Instantiate(musicPrefab);
            DontDestroyOnLoad(music); 
        }
        AudioSource musicSource = music.GetComponent<AudioSource>();
        musicSource.volume = volume;
        if (track != musicSource.clip)
        {
            musicSource.Stop();
            musicSource.clip = track;
            musicSource.Play();
        }
            
    }

    private void Update()
    {
        AudioSource musicSource = music.GetComponent<AudioSource>();
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }
}
