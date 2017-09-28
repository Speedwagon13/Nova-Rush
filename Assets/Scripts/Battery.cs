using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {

    private float damageRate;
    private int hitPoints;
    private float lastHit;
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        hitPoints = 5;
        damageRate = Time.time;
        lastHit = Time.time;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendlyDamageDealer" || other.tag == "enemyDamageDealer")
        {
            if (Time.time > lastHit + damageRate)
                {
                hitPoints--;
                }
        }
    }

    private void Update()
    {
        if (hitPoints <= 0)
        {
            explode();
        }
    }

    private void explode()
    {
        GameObject instantiatedExplosion = Instantiate(explosion);
        instantiatedExplosion.transform.position = transform.position;
        print("Explosion Spawned");
    }
}
