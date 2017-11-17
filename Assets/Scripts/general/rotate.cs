using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xPos = 2.5f * Mathf.Cos(Time.time / 4 + (Mathf.PI / 3));
        float yPos = 2.5f * Mathf.Sin(Time.time / 4 + (Mathf.PI / 3));
        transform.forward =  (new Vector3 (xPos, 0, yPos));
	}
}
