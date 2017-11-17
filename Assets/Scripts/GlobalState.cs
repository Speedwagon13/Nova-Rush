using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalState : MonoBehaviour {

    public float introTime;
    public float outroTime;
    public float pauseRate;

    public Text introText;
    //public GameObject pauseMenu;
    //public GameObject missionFailedMenu;
    //public GameObject missionClearedMenu;

    public static GlobalState current;

    private GameObject playerShip;

    private static bool paused;
    private static float timePaused;
    private static float timeUnPaused;
    private static bool missionStarting;
    private static bool missionActive;
    private static bool missionFailed;
    private static bool missionEnding;

    private float startTime;

    private void Awake()
    {
        current = this;

        introText.text = "3";
    }

    // Use this for initialization
    void Start () {

        startTime = Time.time;
        playerShip = GameObject.FindGameObjectWithTag("friendly");
        paused = false;
        timePaused = Time.time;
        timeUnPaused = Time.time;

        missionStarting = true;
        missionActive = false;
        missionEnding = false;
        missionFailed = false;
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

        if (GameObject.FindWithTag("friendly") == null && missionActive == true)
        {
            missionFailed = true;
            missionActive = false;
        }
        if (playerShip.GetComponent<playerShipScript>().dead)
        {
            missionActive = false;
            missionFailed = true;
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

        manageIntro();
        managePaused();
        manageFailed();
        manageMissionComplete();
    }

    // menu managers
    private void manageIntro()
    {
        if ((Time.time - startTime) < 3)
        {
            introText.text = ((int)(4 - (Time.time - startTime))).ToString();
        }
        else if ((Time.time - startTime) < 4)
        {
            introText.text = "Mission Start!";
        }
        else
        {
            introText.text = "";
        }
    }

    private void managePaused()
    {
        if (paused)
        {
            //pauseMenu.SetActive(true);
        } else
        {
            //pauseMenu.SetActive(false);
        }
    }

    private void manageFailed()
    {
        if (missionFailed)
        {
            //missionFailedMenu.SetActive(true);
        } else
        {
            //missionFailedMenu.SetActive(false);
        }
    }

    private void manageMissionComplete()
    {
        if (missionEnding)
        {
            //missionClearedMenu.SetActive(true);
        }
        else
        {
            //missionClearedMenu.SetActive(false);
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

    public bool isMissionFailed()
    {
        return missionFailed;
    }

    public bool isMissionEnding()
    {
        return missionEnding;
    }
}
