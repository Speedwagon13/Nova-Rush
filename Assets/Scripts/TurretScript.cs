using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {
    [Header("Bullet and Target Prefabs")]
    public GameObject projectile;
    public GameObject target;

    private float fireRate;
    private float damageRate;
    private int hitPoints;

    private Vector3 heading;
    private float lastShot;
    private float lastDamage;

    void Start()
    {
        heading = transform.forward;
        lastShot = Time.time;
        lastDamage = Time.time;

        fireRate = 2.5f;
        damageRate = 0.05f;
        hitPoints = 5;


        gameObject.tag = "enemy";
    }

    void FixedUpdate()
    {
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
        heading = (target.transform.position - transform.position);
        transform.forward = heading;
        fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)
        {
            if (other.tag == "damageDealerFriendly")
            {
                hitPoints--;
                lastDamage = Time.time;
            }
        }
    }

    private void fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            Vector3 dir = transform.forward;
            GameObject bullet = Instantiate(projectile, transform.position + transform.forward, Quaternion.identity);
            bullet.tag = "damageDealerEnemy";
            lastShot = Time.time;
        }
    }
}
