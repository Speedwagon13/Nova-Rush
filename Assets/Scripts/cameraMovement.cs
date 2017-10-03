using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    private GameObject playerShip;
    private Rigidbody body;

    private void Start()
    {
        playerShip = GameObject.FindWithTag("friendly");
        body = gameObject.GetComponent<Rigidbody>();

        transform.position = new Vector3(0, 19, -19);
    }

    void Update () {
        if (playerShip != null)
        {
        }
	}
}
