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
        body = gameObject.GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("friendly");
    }

    private void OnEnable()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        if (player != null)
        {
            if (player.activeInHierarchy)
            {
                body.velocity = transform.forward * bulletSpeed;
                if (Time.time > spawnTime + lifeSpan)
                {
                    gameObject.SetActive(false);
                }
            } else
            {
                body.velocity = new Vector3(0, 0, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "damageDealerFriendly" && other.tag != "damageDealerFriendly" && other.tag != "friendly")
        {
            body.velocity = new Vector3(0, 0, 0);
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "damageDealerEnemy" && other.tag != "damageDealerEnemy" && other.tag != "enemy")
        {
            body.velocity = new Vector3(0, 0, 0);
            gameObject.SetActive(false);
        }
    }

}
