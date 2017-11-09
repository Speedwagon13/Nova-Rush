using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

    private Vector3 endPos;

    private void Start()
    {
        endPos = transform.position - new Vector3(0, -10, 0);
    }
    private void Update()
    {
        if (transform.GetChild(0) == null)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, .1f);
        }
    }
}
