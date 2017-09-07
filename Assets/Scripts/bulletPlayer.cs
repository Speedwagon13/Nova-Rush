using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPlayer : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy" || other.tag == "damageDealerEnemy" || other.tag == "neutral")
        {
            Destroy(gameObject);
        }
    }

}
