using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private float spawnTime;
    public float lifeSpan = 5f;

	// Use this for initialization
	void Start () {
        spawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > spawnTime + lifeSpan)
        {
            Destroy(this);
        }
	}
}
