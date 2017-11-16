using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemyShip;
    private GameObject[] activeShips;
    private int lim;
    private int radius;
    private float lastSpawnTime;
    private float spawnRate;

	// Use this for initialization
	void Start () {
        lim = 10;
        radius = 20;
        lastSpawnTime = Time.time;
        spawnRate = 5;
        activeShips = new GameObject[lim];
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lastSpawnTime + spawnRate)
        {
            spawn();
            lastSpawnTime = Time.time;
        }
	}

    private void spawn()
    {
        for (int i = 0; i < lim; i++)
        {
            if (activeShips[i] == null)
            {
                activeShips[i] = GameObject.Instantiate(enemyShip, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                return;
            }
        }
    }
}