using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipScript : MonoBehaviour
{
    [Header("Bullet and Target Prefabs")]
    public AudioClip bulletFireClip;

    public float aggroRange;

    private AudioSource audioSource;
    private float movementForce;
    private float movementDrag;
    private float bulletSpeed;
    private float fireRate;
    private float aimSpeed;
    private float damageRate;
    private int hitPoints;
    private bool hasSeenPlayer;

    private GameObject target;
    private Rigidbody body;
    private Vector3 heading;

    private float lastShot;
    private float lastDamage;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        body = GetComponent<Rigidbody>();
        hasSeenPlayer = false;
        heading = transform.forward;
        lastShot = Time.time;
        lastDamage = Time.time;

        movementForce = 20;
        movementDrag = .7f;
        bulletSpeed = 7.5f;
        fireRate = 0.35f;
        damageRate = 0.1f;
        aimSpeed = .5f;
        hitPoints = 5;

        target = GameObject.FindWithTag("friendly");

        gameObject.tag = "enemy";
    }

    void FixedUpdate()
    {
        if (GlobalState.current.isMissionActive())
        {
            // Triggers the enemy when the player is in range
            if (target != null)
            {
                if (!hasSeenPlayer && Vector3.Magnitude(target.transform.position - transform.position) < aggroRange)
                {
                    hasSeenPlayer = true;
                }
            }

            if (hitPoints <= 0)
            {

                GameObject explosion = ExplosionPool.current.getExplosion();

                if (explosion != null)
                {
                    explosion.transform.position = transform.position;
                    explosion.SetActive(true);
                }

                Destroy(gameObject);
            }

            if (target != null && hasSeenPlayer)
            {
                if (target.activeInHierarchy)
                {
                    // make it turn more slowly
                    heading = (target.transform.position - transform.position) * movementForce;
                    heading = Vector3.ClampMagnitude(heading, movementForce);

                    body.AddForce(heading);
                    body.velocity *= movementDrag;

                    transform.forward = Vector3.Slerp(transform.forward, heading, aimSpeed);
                    fire();
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly") {
            hasSeenPlayer = true;
        }
        if (Time.time > damageRate + lastDamage)
        {
            if (other.tag == "damageDealerFriendly")
            {
                hasSeenPlayer = true;
                hitPoints--;
                lastDamage = Time.time;
            }
        }
    }

    private void fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            audioSource.clip = bulletFireClip;
            audioSource.Play();
            GameObject bullet = EnemyBulletPooler.current.getEnemyBullet();

            if (bullet != null)
            {
                bullet.SetActive(true);
                bullet.transform.position = transform.position;
                bullet.transform.forward = transform.forward;

                lastShot = Time.time;
            }
        }
    }
}