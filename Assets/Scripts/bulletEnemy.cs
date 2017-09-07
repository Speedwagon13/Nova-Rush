using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly" || other.tag == "damageDealerFriendly" || other.tag == "neutral")
        {
            Destroy(gameObject);
        }
    }

}
