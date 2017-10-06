using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuScript : MonoBehaviour {

    public GameObject player;
    private bool paused;

	// Use this for initialization
	void Start () {

        paused = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("escape"))
        {
            player.SetActive(true);
            gameObject.SetActive(false);
        }
	}
}
