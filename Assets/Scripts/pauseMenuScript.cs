using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if (GlobalState.current.isPaused())
        {
            gameObject.SetActive(true);
        } else
        {
            gameObject.SetActive(false);
        }
	}
}
