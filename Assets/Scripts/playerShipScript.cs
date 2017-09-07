using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShipScript : MonoBehaviour
{
    [Header("Bullet Prefab")]
    public GameObject projectile;

    [Space(10)]
    [Header("Movement Variables")]
    public float movementForce;
    public float movementDrag;
    public float aimSpeed;
    public float aimDeadzone;
    public float bulletSpeed;
    public float fireRate;
    public float damageRate;

    private Rigidbody body;
    private int hitPoints;
    private float lastShot;
    private float lastDamage;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        hitPoints = 3;
        lastShot = 0.0f;
        lastDamage = 0.0f;

        gameObject.tag = "friendly";
    }

    void Update()
    {
        if (hitPoints <= 0 || transform.position.y < 1)
        {
            Destroy(gameObject);
        }

        if (Input.GetButton("RB"))
        {
            fire();
        }
    }
    
    private void FixedUpdate()
    {
        // Ship movement

        float lx = Input.GetAxis("LeftJoystickX");
        float lz = -Input.GetAxis("LeftJoystickZ");

        Vector3 move = new Vector3(lx, 0, lz) * movementForce;      // Make a vector out of the movement input, scaled by movementForce
        move = Vector3.ClampMagnitude(move, movementForce);         // ... but don't let it get larger than movementForce (clamp length)

        body.AddForce(move);                                        // Add the movement force
        body.velocity *= movementDrag;                              // Slow down the ship with drag

        // Ship aiming

        float rx = Input.GetAxis("RightJoystickX");
        float rz = -Input.GetAxis("RightJoystickZ");

        Vector3 heading = new Vector3(rx, 0, rz);                   // Make a vector out of the aiming input

        if (heading.magnitude > aimDeadzone)                        // If the user is pushing the right stick hard enough, aim the ship (but smoothly!)
        {
            Vector3 smoothHeading = Vector3.Slerp(transform.forward, heading, aimSpeed);
            transform.forward = smoothHeading;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)
        {
            if (other.tag == "damageDealerEnemy")
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
            bullet.tag = "damageDealerFriendly";
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            lastShot = Time.time;
        }
    }
}