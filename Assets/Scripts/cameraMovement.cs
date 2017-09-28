using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject playerShip;

    private void Start()
    {
        transform.position = new Vector3(0, 19, -19);
    }

    void Update () {
        transform.position = playerShip.transform.position + new Vector3(0, 18, -10);
	}
}
