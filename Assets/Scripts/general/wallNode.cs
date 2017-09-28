using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallNode : MonoBehaviour {

    public GameObject nextWallNode;
    public GameObject wall;
    
	void Start () {
		if (nextWallNode != null)
        {
            GameObject spawnedWall = Instantiate(wall, (nextWallNode.transform.position - transform.position) / 2, Quaternion.identity);
        }
	}
}
