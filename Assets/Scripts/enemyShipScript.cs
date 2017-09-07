using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipScript : MonoBehaviour
{

    
    private Vector3 targetLocation;
    private Vector3 targetLocationUnitV;

    public GameObject projectile;
    public GameObject target;

    public float movementSpeed;
    public float bulletSpeed;
    public float fireRate;
    public int hitPoints;

    private float lastShot = 0.0f;

    void Start()
    {
        gameObject.tag = "enemy";
    }

    void Update()
    {
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
        targetLocation = target.transform.position - transform.position;
        targetLocationUnitV = targetLocation / targetLocation.magnitude;
        GetComponent<Rigidbody>().velocity = targetLocationUnitV * movementSpeed;
        transform.forward = targetLocationUnitV;
        fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "damageDealerFriendly")
        {
            hitPoints--;
        }
    }

    private void fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            Vector3 dir = transform.forward;
            GameObject bullet = Instantiate(projectile, transform.position + transform.forward, Quaternion.identity);
            bullet.tag = "damageDealerEnemy";
            bullet.GetComponent<Rigidbody>().velocity = targetLocationUnitV * bulletSpeed;
            lastShot = Time.time;
        }
    }
}