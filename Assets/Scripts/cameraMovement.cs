using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject playerShip;
    private Rigidbody body;

    private void Start()
    {
        
        body = gameObject.GetComponent<Rigidbody>();

        transform.position = playerShip.transform.position + new Vector3(0, 19, -11);
    }

    void Update () {
        if (playerShip != null)
        {
            transform.position = playerShip.transform.position + new Vector3(0, 19, -11);
        }
	}
}
