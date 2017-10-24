using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public float bombTime;
    public int bulletCount;
    public int shrapnelSpeed;

    public float movementForce;
    public float movementDrag;

    public GameObject shrapnel;

    private float spawnTime;
    private GameObject target;
    private Vector3 heading;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        spawnTime = Time.time;
        target = GameObject.FindWithTag("friendly");
        heading = target.transform.position - transform.position;
    }

    private void FixedUpdate()
    {

        if (GlobalState.current.isMissionActive())
        {
            if (Time.time > spawnTime + bombTime)
            {
                explode();
            }

            //Track the playerShip and move toward it
            if (target.activeInHierarchy)
            {
                heading = (target.transform.position - transform.position) * movementForce;
                heading = Vector3.ClampMagnitude(heading, movementForce);
                body.AddForce(heading);

                body.velocity *= movementDrag;
                transform.forward = heading;
            }
        } else
        {
            //body.velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly" || other.tag == "damageDealerFriendly" || other.tag == "neutral")
        {
            explode();
        }
    }

    //Details for Bomb Detonation
    private void explode()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = EnemyBulletPooler.current.getEnemyBullet();
            if (bullet != null)
            {
                bullet.SetActive(true);

                float xComp = Mathf.Cos(2 * Mathf.PI * i / bulletCount);// x comp
                float zComp = Mathf.Sin(2 * Mathf.PI * i / bulletCount);// z comp

                Vector3 shrapnelDir = new Vector3(xComp, 0, zComp);

                bullet.transform.position = transform.position;
                bullet.transform.forward = shrapnelDir.normalized;
            }
            
        }
        gameObject.SetActive(false);
    }
}
