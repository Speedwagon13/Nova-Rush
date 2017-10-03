using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public GameObject otherTeleporter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "friendly")
        {
            other.transform.position = otherTeleporter.transform.position;
        }
    }

}
