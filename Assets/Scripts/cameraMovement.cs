using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject playerShip;
    public float rotationScalar;
    public float rotationRadius;
    private Vector3 originalPos;
    private Rigidbody body;
    private float startTime;

    private void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        originalPos = playerShip.transform.position + new Vector3(0, 29, -11);
        transform.position = originalPos;
        startTime = Time.time;
    }
    void Update () {
        if (playerShip != null)
        {
            if (GlobalState.current.isMissionStarting())
            {
                float theta = Mathf.PI + (Mathf.PI / 2) * (Time.time - startTime) / (GlobalState.current.introTime);
                float zComp = 10f * Mathf.Cos(theta);
                float yComp = 10f * Mathf.Sin(theta);
                transform.position = originalPos + new Vector3(0, yComp, zComp);
            } else if (GlobalState.current.isMissionEnding() || GlobalState.current.isMissionFailed())
            {
                rotateAboutPlayer();
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, playerShip.transform.position + new Vector3(0, 19, -11), 1f);
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
