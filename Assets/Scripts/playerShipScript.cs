using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShipScript : MonoBehaviour
{

    [Header("Bullet Prefab")]
    public GameObject projectile;

    private Rigidbody body;
    private float movementForce;
    private float movementDrag;
    private float aimSpeed;
    private float aimDeadzone;
    private float bulletSpeed;
    private float fireRate;
    private float damageRate;
    private int hitPoints;
    private float lastShot;
    private float lastDamage;
    private bool usingController;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        hitPoints = 3;
        lastShot = Time.time;
        lastDamage = Time.time;
        usingController = false;

        // Movement Variables
        movementForce = 180;
        movementDrag = .7f;
        aimSpeed = .5f;
        aimDeadzone = .1f;
        bulletSpeed = 20;
        fireRate = .125f;
        damageRate = 1.5f;

        gameObject.tag = "friendly";
    }

    void Update()
    {
        //Detects whether you are using a controller or mouse and keyboard
        if (Input.GetAxis("LeftJoystickX") > 0 || Input.GetAxis("RightJoystickX") > 0 || Input.GetAxis("LeftJoystickZ") > 0 || Input.GetAxis("RightJoystickZ") > 0)
        {
            usingController = true;
        } else
        {
            usingController = false;
        }
        //kills you if your hitpoints fall below 0
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
        //fires a bullet if you press fire
        if (Input.GetButton("RB") || Input.GetAxis("Fire1") > 0)
        {
            fire();
        }
    }
    
    private void FixedUpdate()
    {
        // Ship movement with controller
        if (usingController)
        {
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
            Vector3 optionalHeading = new Vector3(lx, 0, lz);           // Make heading out of the movement input

            if (heading.magnitude > aimDeadzone)                        // If the user is pushing the right stick hard enough, aim the ship (but smoothly!)
            {
                Vector3 smoothHeading = Vector3.Slerp(transform.forward, heading, aimSpeed);
                transform.forward = smoothHeading;
            }
            else
            {
                Vector3 smoothOptionalHeading = Vector3.Slerp(transform.forward, optionalHeading, aimSpeed);
                transform.forward = smoothOptionalHeading;
            }
        } 

        //Ship movement using Mouse and Keyboard
        if (!usingController)
        {
            int right = 0;
            int left = 0;
            int up = 0;
            int down = 0;

            if (Input.GetKey("d"))
            {
                right = 1;
            }
            if (Input.GetKey("a"))
            {
                left = 1;
            }
            if (Input.GetKey("w"))
            {
                up = 1;
            }
            if (Input.GetKey("s"))
            {
                down = 1;
            }

            Vector3 move = new Vector3(right - left, 0, up - down) * movementForce;      // Make a vector out of the movement input, scaled by movementForce
            move = Vector3.ClampMagnitude(move, movementForce);                          // ... but don't let it get larger than movementForce (clamp length)

            body.AddForce(move);                                                         // Add the movement force
            body.velocity *= movementDrag;                                               // Slow down the ship with drag

            float mosX = Input.mousePosition.x - (Screen.width / 2);
            float mosY = Input.mousePosition.y - (Screen.height / 2);

            Vector3 target = new Vector3(mosX, 0, mosY);
            Vector3 heading = target - transform.position;

            transform.forward = heading;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)                                        //Damages you if you are hit by an enemy projectile and your i-frames have ended
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
            bullet.transform.forward = transform.forward;
            bullet.tag = "damageDealerFriendly";
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            lastShot = Time.time;
        }
    }
}