using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShieldScript : MonoBehaviour {

    public GameObject ship;
    public int radius;
    private float t;
    private Vector3 startingPos;

    private void Start()
    {
        startingPos = gameObject.transform.position - ship.transform.position;
        float xComp = startingPos.x;
        float yComp = startingPos.z;

        t = Mathf.Acos(Mathf.Abs(xComp) / radius);

        if (xComp > 0 && yComp >= 0)
        {
            t = t + 0;
        } else if (xComp <= 0 && yComp > 0)
        {
            t = Mathf.PI - t;
        } else if (xComp < 0 && yComp <= 0)
        {
            t = Mathf.PI + t;
        } else if (xComp >= 0 && yComp < 0)
        {
            t = - t;
        }
    }

    // Update is called once per frame
    void Update () {

        

        Vector3 shipPosition = ship.transform.position;
        float xPos = radius * Mathf.Cos(Time.time / 4 + t);
        float yPos = radius * Mathf.Sin(Time.time / 4 + t);
        gameObject.transform.position = shipPosition + new Vector3(xPos, 0, yPos);

        gameObject.transform.forward = gameObject.transform.position - shipPosition;

	}
}
