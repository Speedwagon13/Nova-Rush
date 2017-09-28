using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour {

    public int bouncePower;

    public void OnTriggerEnter(Collider other)
    {
        GameObject wallBody = gameObject;
        Rigidbody body = other.GetComponent<Rigidbody>();

        if (other.tag == "damageDealerFriendly" || other.tag == "damageDealerEnemy")
        {
            if (body.position.x > wallBody.transform.position.x)
            {
                body.AddForce(new Vector3(1, 0, 0) * bouncePower);
            }
            if (body.position.x < wallBody.transform.position.x)
            {
                body.AddForce(new Vector3(-1, 0, 0) * bouncePower);
            }
            if (body.position.z > wallBody.transform.position.z)
            {
                body.AddForce(new Vector3(0, 0, 1) * bouncePower);
            }
            if (body.position.z < wallBody.transform.position.z)
            {
                body.AddForce(new Vector3(0, 0, -1) * bouncePower);
            }
        }

    }
}
