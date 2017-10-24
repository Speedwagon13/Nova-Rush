using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject playerShip;
    public float rotationScalar;
    public float rotationRadius;
    private Rigidbody body;

    void Update () {
        if (playerShip != null)
        {
            if (GameObject.FindWithTag("enemy") == null)
            {
                rotateAboutPlayer();
            }
            else
            {
                transform.position = playerShip.transform.position + new Vector3(0, 19, -11);
            }
        }
	}

    void rotateAboutPlayer()
    {
        Vector3 initialPosition = playerShip.transform.position + new Vector3(0, 2, 0);
        float xComp = rotationRadius * Mathf.Cos(Time.time);
        float yComp = rotationRadius * Mathf.Sin(Time.time);
        transform.position = initialPosition + rotationScalar * (new Vector3(xComp, 0, yComp));

        transform.LookAt(playerShip.transform.position);
    }
}
