using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour {

    public void OnCollisionEnter(Collision col)
    {
        GameObject bul = col.collider.gameObject;
        bul.transform.position = 3 * (bul.transform.forward + col.contacts[0].normal);
        bul.transform.forward = bul.transform.forward + col.contacts[0].normal;
    }
}
