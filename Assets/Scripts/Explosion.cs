using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private float spawnTime;
    private float lifeSpan;

	// Use this for initialization
	void Start () {
        spawnTime = Time.time;
        lifeSpan = .1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > spawnTime + lifeSpan)
        {
            Destroy(gameObject);
        }
	}
}
