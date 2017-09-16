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

        spawnTime = Time.time;
        target = GameObject.FindWithTag("friendly");
        heading = target.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        if (Time.time > spawnTime + bombTime)
        {
            explode();
        }

        //Track the playerShip and move toward it
        heading = (target.transform.position - transform.position) * movementForce;
        heading = Vector3.ClampMagnitude(heading, movementForce);
        body.AddForce(heading);

        body.velocity *= movementDrag;
        transform.forward = heading;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly" || other.tag == "damageDealerFriendly" || other.tag == "neutral")
        {
            explode();
            Destroy(gameObject);
        }
    }

    //Details for Bomb Detonation
    private void explode()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = Instantiate(shrapnel, transform.position - transform.forward, Quaternion.identity);
            shrapnel.tag = "damageDealerEnemy";

            float xComp = Mathf.Cos(2 * Mathf.PI * i / bulletCount);// x comp
            float zComp = Mathf.Sin(2 * Mathf.PI * i / bulletCount);// z comp

            Vector3 shrapnelDir = new Vector3(xComp, 0, zComp);
            shrapnelDir = shrapnelSpeed * shrapnelDir.normalized;

            bullet.GetComponent<Rigidbody>().velocity = shrapnelDir;
        }
        Destroy(gameObject);
    }
}
