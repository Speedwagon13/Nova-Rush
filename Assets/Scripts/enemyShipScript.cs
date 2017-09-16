using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipScript : MonoBehaviour
{
    [Header("Bullet and Target Prefabs")]
    public GameObject projectile;
    public GameObject target;

    private float movementForce;
    private float movementDrag;
    private float bulletSpeed;
    private float fireRate;
    private float damageRate;
    private int hitPoints;

    private Rigidbody body;
    private Vector3 heading;

    private float lastShot;
    private float lastDamage;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        heading = transform.forward;
        lastShot = Time.time;
        lastDamage = Time.time;

        movementForce = 20;
        movementDrag = .7f;
        bulletSpeed = 7.5f;
        fireRate = 0.35f;
        damageRate = 0.05f;
        hitPoints = 2;

        gameObject.tag = "enemy";
    }

    void FixedUpdate()
    {
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
        heading = (target.transform.position - transform.position) * movementForce;
        heading = Vector3.ClampMagnitude(heading, movementForce);

        body.AddForce(heading);
        body.velocity *= movementDrag;

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
            bullet.GetComponent<Rigidbody>().velocity = heading.normalized * bulletSpeed;
            lastShot = Time.time;
        }
    }
}