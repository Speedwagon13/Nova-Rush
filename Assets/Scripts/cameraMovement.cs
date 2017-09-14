using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject playerShip;
 
	void Update () {
        transform.position = playerShip.transform.position + new Vector3(0, 18, -10);
	}
}
