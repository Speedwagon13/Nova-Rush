using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldShipScript : MonoBehaviour
{

    public float fireRate;
    public int hitPoints;
    public float aggroRange;
    public float speed;
    public float damageRate;
    public AudioClip bulletFireClip;

    private AudioSource audioSource;
    private float spawnTime;
    private bool hasSeenPlayer;
    private float lastShot;
    private float lastDamage;
    private float t;
    private GameObject player;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        spawnTime = Time.time;
        lastShot = Time.time;
        lastDamage = Time.time;
        player = GameObject.FindWithTag("friendly");

        t = Mathf.PI / 6;

    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalState.current.isMissionActive())
        {
            // Triggers the enemy when the player is in range
            if (player != null)
            {
                if (!hasSeenPlayer && Vector3.Magnitude(player.transform.position - transform.position) < aggroRange)
                {
                    hasSeenPlayer = true;
                }
            }

            if (hitPoints <= 0)
            {
                GameObject explosion = ExplosionPool.current.getExplosion();
                explosion.SetActive(true);
                explosion.transform.position = transform.position;
                Destroy(gameObject);
            }

            if (player != null && hasSeenPlayer)
            {
                if (player.activeInHierarchy)
                {
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

            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = EnemyBulletPooler.current.getEnemyBullet();
                bullet.SetActive(true);
                float xPos = speed * 2.5f * Mathf.Cos(Time.time / 4 + i * 2 * Mathf.PI / 3 + t);
                float yPos = speed * 2.5f * Mathf.Sin(Time.time / 4 + i * 2 * Mathf.PI / 3 + t);
                bullet.transform.position = transform.position + new Vector3(xPos, 0, yPos);
                bullet.transform.forward = bullet.transform.position - transform.position;
            }
            
            lastShot = Time.time;
        }
    }
}
