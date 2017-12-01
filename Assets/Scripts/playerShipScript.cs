using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerShipScript : MonoBehaviour
{

    [Header("Ability Cooldown")]
    public float abilityCooldown;
    public float dashLength;
    public float dashSpeed;
    public AudioClip damagedSound;
    public AudioClip bulletFire;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public ParticleSystem particle1;
    public GameObject model;

    private Rigidbody body;
    private MeshRenderer mesh;

    private float movementForce;
    private float movementDrag;
    private float aimSpeed;
    private float aimDeadzone;
    private float bulletSpeed;
    private float fireRate;
    private float damageRate;
    private float lastShot;
    private float lastDamage;
    private float lastAbility;
    private AudioSource audioSource;

    public int hitPoints;
    
    private bool usingController;
    private bool dashing;
    public bool dead;

    void Start()
    {
        mesh = model.GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();
        hitPoints = 3;
        lastShot = Time.time;
        lastDamage = Time.time;
        lastAbility = Time.time;
        usingController = false;
        dashing = false;
        dead = false;

        //Movement Variables
        movementForce = 180;
        movementDrag = .7f;
        aimSpeed = .5f;
        aimDeadzone = .1f;
        fireRate = .125f;
        damageRate = 3f;

        gameObject.tag = "friendly";
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    
    private void FixedUpdate()
    {
        if (GlobalState.current.isMissionActive())
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
            if (!dashing)
            {
                Vector3 move = (new Vector3(moveInputX, 0, moveInputZ)) * movementForce;

                body.AddForce(move);                                                                            // Add the movement force
                body.velocity *= movementDrag;                                                                  // Slow down the ship with drag
            }
            else
            {
                Vector3 dashDir = (new Vector3(moveInputX, 0, moveInputZ)).normalized;
                body.velocity = (dashDir * dashSpeed);
                if (Time.time > lastAbility + dashLength)
                {
                    dashing = false;
                }
            }

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

            float mag;

            mag = Mathf.Sqrt(Mathf.Pow(Input.GetAxis("RightJoystickX"), 2) + Mathf.Pow(Input.GetAxis("RightJoystickZ"), 2));

            //Fires a bullet if you press fire
            if (Input.GetButton("RB") || Input.GetAxis("Fire1") > 0 || mag > .3f)
            {
                fire();
            }

            if (Input.GetButton("LB") || Input.GetAxis("Fire2") > 0)
            {
                dash();
            }

            //Kills you if your hitpoints fall below 0
            if (hitPoints <= 0)
            {
                die();
            }

            if (Time.time < damageRate + lastDamage)
            {
                flicker();
            } else
            {
                mesh.enabled = true;
            }

        } else
        {
            body.velocity = new Vector3(0, 0, 0);
        }
    }

    private void flicker()
    {
        if (mesh.enabled)
        {
            mesh.enabled = false;
        } else
        {
            mesh.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time > damageRate + lastDamage)                                                        //Damages you if you are hit by an enemy projectile and your i-frames have ended
        {
            if (other.tag == "damageDealerEnemy")
            {
                if (!dashing)
                {
                    audioSource.clip = damagedSound;
                    audioSource.Play();
                    if (hitPoints == 3)
                    {
                        GameObject particle = PlayerExplosionPool.current.getExplosion();
                        particle.SetActive(true);
                        particle.transform.position = health3.transform.position;
                        GameObject.Destroy(health3);
                    } else if (hitPoints == 2)
                    {
                        GameObject particle = PlayerExplosionPool.current.getExplosion();
                        particle.SetActive(true);
                        particle.transform.position = health2.transform.position;
                        GameObject.Destroy(health2);
                    } else if (hitPoints == 1)
                    {
                        GameObject particle = PlayerExplosionPool.current.getExplosion();
                        particle.SetActive(true);
                        particle.transform.position = health1.transform.position;
                        GameObject.Destroy(health1);
                    }
                    hitPoints--;
                    lastDamage = Time.time;
                }
            }
        }
    }

    private void fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            GameObject bullet = PlayerBulletPooler.current.getPlayerBullet();

            particle1.Play();

            audioSource.clip = bulletFire;
            audioSource.Play();

            if (bullet != null)
            {
                bullet.transform.position = transform.position + transform.forward * 2;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                lastShot = Time.time;
            }
        }
    }

    private void dash()
    {
        if (Time.time > lastAbility + abilityCooldown)
        {
            lastAbility = Time.time;
            dashing = true;
        }
    }

    private void die()
    {
        GameObject explosion = ExplosionPool.current.getExplosion();
        explosion.SetActive(true);
        explosion.transform.position = transform.position;
        dead = true; 
        gameObject.SetActive(false);
    }
}