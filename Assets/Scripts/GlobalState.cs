using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalState : MonoBehaviour {

    public float introTime;
    public float outroTime;
    public float pauseRate;

    public static GlobalState current;

    private static bool paused;
    private static float timePaused;
    private static float timeUnPaused;
    private static bool missionStarting;
    private static bool missionActive;
    private static bool missionEnding;

    private float startTime;

    private void Awake()
    {
        current = this;
    }

    // Use this for initialization
    void Start () {

        startTime = Time.time;

        paused = false;
        timePaused = Time.time;
        timeUnPaused = Time.time;

        missionStarting = true;
        missionActive = false;
        missionEnding = false;
	}

    private void Update()
    {
        if (Time.time > startTime + introTime && missionStarting == true)
        {
            missionActive = true;
            missionStarting = false;
        }

        if (GameObject.FindWithTag("enemy") == null && missionActive ==true)
        {
            missionEnding = true;
            missionActive = false;
        }

        if (Input.GetKeyDown("p") && !paused)
        {
            print("paused");
            Time.timeScale = 0f;
            timePaused = Time.time;
            paused = true;
        } else if (Input.GetKeyDown("p") && paused)
        {
            print("unpaused");
            Time.timeScale = 1.0f;
            timeUnPaused = Time.time;
            paused = false;
        }
    }


    // Getters
    public bool isPaused()
    {
        return paused;
    }

    public float getTimePaused()
    {
        return timePaused;
    }

    public float getTimeUnPaused()
    {
        return timeUnPaused;
    }

    public bool isMissionStarting()
    {
        return missionStarting;
    }

    public bool isMissionActive()
    {
        return missionActive;
    }

    public bool isMissionEnding()
    {
        return missionEnding;
    }
}
