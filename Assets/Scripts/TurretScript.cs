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
        //If hit points are less than 0, kill the ship
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }

        //Turn towards the player
        heading = (target.transform.position - transform.position);
        transform.forward = heading;

        //Fires a bomb
        fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        //ship will take a point of damage if hit by player and i-frames have not ended
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
            GameObject bullet = Instantiate(projectile, transform.position + transform.forward, Quaternion.identity);
            bullet.tag = "damageDealerEnemy";
            lastShot = Time.time;
        }
    }
}
