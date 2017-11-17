using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemyShip;
    private GameObject[] activeShips;
    private float damageRate;
    private float lastDamage;
    private int hp;
    private int lim;
    private int radius;
    private float lastSpawnTime;
    private float spawnRate;
	private GameObject target;

	// Use this for initialization
	void Start () {
        hp = 8;
        lim = 10;
        radius = 20;
        damageRate = .1f;
        lastDamage = Time.time;
        lastSpawnTime = Time.time;
        spawnRate = 5;
        activeShips = new GameObject[lim];
		target = GameObject.FindWithTag("friendly");
    }
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Magnitude (target.transform.position - transform.position) < radius) {
			
			if (Time.time > lastSpawnTime + spawnRate) {
				spawn ();
				lastSpawnTime = Time.time;
			}
		}
        if (hp <= 0)
        {
            GameObject explosion = ExplosionPool.current.getExplosion();

            if (explosion != null)
            {
                explosion.transform.position = transform.position;
                explosion.SetActive(true);
            }

            Destroy(gameObject);
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

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)
        {
            if (other.tag == "damageDealerFriendly")
            {
                hp--;
                lastDamage = Time.time;
            }
        }
    }
}