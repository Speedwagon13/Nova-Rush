using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPlayer : MonoBehaviour {

    private float spawnTime;
    private float lifeSpan;

    private void Awake()
    {
        spawnTime = Time.time;
        lifeSpan = 1f;
    }

    private void Update()
    {
        if (Time.time > spawnTime + lifeSpan)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy" || other.tag == "damageDealerEnemy" || other.tag == "neutral")
        {
            Destroy(gameObject);
        }
    }

}
