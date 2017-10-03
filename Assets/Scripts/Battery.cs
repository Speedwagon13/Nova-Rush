using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {

    private float damageRate;
    private int hitPoints;
    private float lastDamage;
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        hitPoints = 5;
        damageRate = 1f;
        lastDamage = Time.time;
	}

    private void OnTriggerEnter(Collider other)
    {
        print("hit");
        if (other.tag == "damageDealerFriendly")
        {
            if (Time.time > lastDamage + damageRate)
                {
                hitPoints--;
                print("damage taken");
                }
        }
    }

    private void Update()
    {
        if (hitPoints <= 0)
        {
            explode();
            Destroy(gameObject);
        }
    }

    private void explode()
    {
        GameObject instantiatedExplosion = Instantiate(explosion);
        instantiatedExplosion.transform.position = transform.position;
        print("Explosion Spawned");
    }
}
