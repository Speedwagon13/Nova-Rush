using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadShotShip : MonoBehaviour
{
	[Header("Bullet and Target Prefabs")]
	public float aggroRange;
    public AudioClip bulletFireSound;

    private AudioSource audioSource;
	private float movementForce;
	private float movementDrag;
	private float bulletSpeed;
	public float fireRate;
	private float damageRate;
	private int hitPoints;
	private bool hasSeenPlayer;
	public float spread;

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

		movementForce = 10;
		movementDrag = .6f;
		bulletSpeed = 3.75f;
		fireRate = 0.25f;
		damageRate = 0.05f;
		hitPoints = 8;

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
                explosion.SetActive(true);
                explosion.transform.position = transform.position;
                Destroy(gameObject);
            }

            if (target != null && hasSeenPlayer)
            {
                heading = (target.transform.position - transform.position) * movementForce;
                heading = Vector3.ClampMagnitude(heading, movementForce);

                //			body.AddForce(heading);
                //			body.velocity *= movementDrag;

                transform.forward = heading;
                fire();
            }
        }
	}

	private void OnTriggerEnter(Collider other)
	{
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
            audioSource.clip = bulletFireSound;
            audioSource.Play();
//			GameObject bullet = EnemyBulletPooler.current.getEnemyBullet();
			GameObject bullet2 = EnemyBulletPooler.current.getEnemyBullet();
			bullet2.SetActive (true); //have to set first bullet to active before getting second.
			GameObject bullet3 = EnemyBulletPooler.current.getEnemyBullet();
			bullet3.SetActive (true);
			if (bullet2 != null && bullet3 != null && bullet2 != bullet3)
			{
//				bullet.SetActive(true);
				bullet2.SetActive (true);
				bullet3.SetActive (true);
//				bullet.transform.position = transform.position;
				bullet2.transform.position = transform.position;
				bullet3.transform.position = transform.position;
//				bullet.transform.forward = transform.forward;
				//Sets the forward direction of the objects. Higher spread is further apart
				bullet2.transform.forward = (transform.forward + (spread * transform.right) + (.6f * transform.right * Vector3.Dot(transform.right,
					Vector3.Normalize(target.GetComponent<Rigidbody>().GetPointVelocity(target.transform.position)))));
				bullet3.transform.forward = (transform.forward - (spread * transform.right) + (.6f * transform.right * Vector3.Dot(transform.right,
					Vector3.Normalize(target.GetComponent<Rigidbody>().GetPointVelocity(target.transform.position)))));
				lastShot = Time.time;
			}
		}
	}
}


