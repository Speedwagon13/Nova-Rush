using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    private float spawnTime;
    private float lifeSpan;

    private void Awake()
    {
        spawnTime = Time.time;
        lifeSpan = 5f;
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
        if (other.tag == "friendly" || other.tag == "damageDealerFriendly" || other.tag == "neutral")
        {
            Destroy(gameObject);
        }
    }

}
