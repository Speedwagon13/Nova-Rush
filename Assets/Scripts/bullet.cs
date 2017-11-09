using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float spawnTime;
    public float bulletSpeed;
    public float lifeSpan;
    private Rigidbody body;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("friendly");
        body = gameObject.GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        if (GlobalState.current.isMissionActive())
        {
            if (player.activeInHierarchy)
            {
                body.velocity = transform.forward * bulletSpeed;
            }

            if (Time.time > spawnTime + lifeSpan)
            {
                gameObject.SetActive(false);
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (gameObject.tag == "damageDealerFriendly" && other.tag == "enemy")
        {
            GameObject explosion = EnemyExplosionPool.current.getExplosion();
            if (explosion != null)
            {
                explosion.transform.position = transform.position;
                explosion.SetActive(true);
            }

            body.velocity = new Vector3(0, 0, 0);
            gameObject.SetActive(false);

        } else if (gameObject.tag == "damageDealerEnemy" && other.tag == "friendly")
        {
            GameObject explosion = PlayerExplosionPool.current.getExplosion();
            if (explosion != null)
            {
                explosion.transform.position = transform.position;
                explosion.SetActive(true);
            }

            body.velocity = new Vector3(0, 0, 0);
            gameObject.SetActive(false);

        } else if (gameObject.tag == "damageDealerFriendly" && other.tag == "neutral")
        {
            GameObject explosion = EnemyExplosionPool.current.getExplosion();
            if (explosion != null)
            {
                explosion.transform.position = transform.position;
                explosion.SetActive(true);
            }
            // null reference exception was being thrown here. not sure why
            if (body.velocity != null)
            {
                body.velocity = new Vector3(0, 0, 0);
            }
            
            gameObject.SetActive(false);

        } else if (gameObject.tag == "damageDealerEnemy" && other.tag == "neutral")
        {
            GameObject explosion = PlayerExplosionPool.current.getExplosion();
            if (explosion != null)
            {
                explosion.transform.position = transform.position;
                explosion.SetActive(true);
            }

            body.velocity = new Vector3(0, 0, 0);
            gameObject.SetActive(false);
        }
    }

}
