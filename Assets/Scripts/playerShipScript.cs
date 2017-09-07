using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShipScript : MonoBehaviour
{
    private CharacterController characterController;
    
    private Vector3 movementVector;
    private Vector3 heading;
    private int hitPoints;

    public GameObject projectile;

    public float movementSpeed;
    public float bulletSpeed;
    public float fireRate;
    public float damageRate;
    private float lastShot;
    private float lastDamage;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
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

        movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;
        movementVector.y = 0;
        movementVector.z = -Input.GetAxis("LeftJoystickZ") * movementSpeed;


        GetComponent<Rigidbody>().velocity = movementVector;
        

        if (Input.GetButton("RB"))
        {
            fire();
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

    private void FixedUpdate()
    {
        heading.x = Input.GetAxis("RightJoystickX");
        heading.y = 0;
        heading.z = -Input.GetAxis("RightJoystickZ");

        transform.forward = heading;
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
