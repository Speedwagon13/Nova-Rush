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
    private float lastShot;
    private float lastDamage;

    private int hitPoints;
    
    private bool usingController;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        hitPoints = 3;
        lastShot = Time.time;
        lastDamage = Time.time;
        usingController = false;

        //Movement Variables
        movementForce = 180;
        movementDrag = .7f;
        aimSpeed = .5f;
        aimDeadzone = .1f;
        bulletSpeed = 20;
        fireRate = .125f;
        damageRate = 1.5f;

        gameObject.tag = "friendly";
    }
    
    private void FixedUpdate()
    {
        //Booleans for any mouse movement and any keys pressed
        bool mosMoved = Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0;
        bool w = Input.GetKey("w");
        bool a = Input.GetKey("a");
        bool s = Input.GetKey("s");
        bool d = Input.GetKey("d");

        //Input Variables
        float moveInputX = 0f;
        float moveInputZ = 0f;
        float aimInputX = 0f;
        float aimInputZ = 0f;

        //Sets usingController to true or false depending your input
        if (w || a || s || d || mosMoved)
        {
            usingController = false;
        }
        else
        {
            usingController = true;
        }

        // Input with controller
        if (usingController)
        {
            moveInputX = Input.GetAxis("LeftJoystickX");
            moveInputZ = -Input.GetAxis("LeftJoystickZ");
            aimInputX = Input.GetAxis("RightJoystickX");
            aimInputZ = -Input.GetAxis("RightJoystickZ");
        } 

        //Input with Mouse and Keyboard
        if (!usingController)
        {
            moveInputX = Input.GetAxis("Horizontal");
            moveInputZ = Input.GetAxis("Vertical");
            aimInputX = Input.mousePosition.x - (Screen.width / 2);
            aimInputZ = Input.mousePosition.y - (Screen.height / 2);
        }

        //Ship Movement
        Vector3 move = new Vector3(moveInputX, 0, moveInputZ) * movementForce;                          // Make a vector out of the movement input, scaled by movementForce
        move = Vector3.ClampMagnitude(move, movementForce);                                             // ... but don't let it get larger than movementForce (clamp length)

        body.AddForce(move);                                                                            // Add the movement force
        body.velocity *= movementDrag;                                                                  // Slow down the ship with drag

        // Ship aiming
        Vector3 heading = new Vector3(aimInputX, 0, aimInputZ);                                         // Make a vector out of the aiming input
        Vector3 optionalHeading = new Vector3(moveInputX, 0, moveInputZ);                               // Make optional heading out of the movement input
        Vector3 smoothHeading = Vector3.Slerp(transform.forward, heading, aimSpeed);
        Vector3 smoothOptionalHeading = Vector3.Slerp(transform.forward, optionalHeading, aimSpeed);

        if (heading.magnitude > aimDeadzone)                                                            
        { 
            transform.forward = smoothHeading;                                                          // If the user is pushing the right stick hard enough, aim the ship (but smoothly!)
        }
        else
        {
            transform.forward = smoothOptionalHeading;                                                  //This way the ship isnt perpetually strafing
        }

        //Fires a bullet if you press fire
        if (Input.GetButton("RB") || Input.GetAxis("Fire1") > 0)
        {
            fire();
        }

        //Kills you if your hitpoints fall below 0
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)                                                        //Damages you if you are hit by an enemy projectile and your i-frames have ended
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