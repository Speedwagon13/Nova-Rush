using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    GameObject[] enemies;

    // Use this for initialization
    void Start () {

        enemies = GameObject.FindGameObjectsWithTag("enemy");

	}

	void Update () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly")
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Destroy(enemies[i]);
            }
        }
    }
}
