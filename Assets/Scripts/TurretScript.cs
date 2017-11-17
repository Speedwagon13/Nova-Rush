using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

    [Header("Bullet and Target Prefabs")]
    public GameObject projectile;
    public float aggroRange;

    private GameObject target;

    private float fireRate;
    private float damageRate;
    private int hitPoints;
    private bool aggrod;

    private Vector3 heading;
    private float lastShot;
    private float lastDamage;
    private GameObject myBomb;

    void Start()
    {
        heading = transform.forward;
        lastShot = Time.time;
        lastDamage = Time.time;

        target = GameObject.FindWithTag("friendly");

        fireRate = 2.5f;
        damageRate = 0.05f;
        hitPoints = 10;

        myBomb = Instantiate(projectile);
        myBomb.SetActive(false);

        gameObject.tag = "enemy";
    }

    void FixedUpdate()
    {
        if (!GlobalState.current.isMissionStarting() && !GlobalState.current.isMissionEnding())
        {
            //If hit points are less than 0, kill the turret
            if (hitPoints <= 0)
            {
                GameObject explosion = ExplosionPool.current.getExplosion();
                explosion.SetActive(true);
                explosion.transform.position = transform.position;
                Destroy(gameObject);
            }

            if (aggrod)
            {
                //Turn towards the player
                if (target.activeInHierarchy)
                {
                    heading = (target.transform.position - transform.position);
                    transform.forward = heading;

                    //Fires a bomb
                    fire();
                }
            }
            else
            {
                if (Vector3.Magnitude(target.transform.position - transform.position) <= aggroRange)
                {
                    aggrod = true;
                }
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        //ship will take a point of damage if hit by player and i-frames have not ended
        if (Time.time > damageRate + lastDamage)
        {
            if (other.tag == "damageDealerFriendly")
            {
                aggrod = true;
                hitPoints--;
                lastDamage = Time.time;
            }
        }
    }

    private void fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            if (!myBomb.activeInHierarchy)
            {
                myBomb.SetActive(true);
                myBomb.transform.position = transform.position;
                myBomb.transform.rotation = transform.rotation;
                lastShot = Time.time;
            }
        }
    }
}
