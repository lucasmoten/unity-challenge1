using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    private Vector3 offsetPosition;

    // To the right of the plane
    private Vector3 rightOfPlanePosition = new Vector3(30, 0, 10); // rotation y=-90
    private Vector3 rightOfPlaneRotation;

    // Behind plane
    private Vector3 behindPlanePosition = new Vector3(0, 3, -15);

    // Start is called before the first frame update
    void Start()
    {
        offsetPosition = rightOfPlanePosition;
        rightOfPlaneRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            offsetPosition = behindPlanePosition;
        }
        if (Input.GetKey("2"))
        {
            offsetPosition = rightOfPlanePosition;
        }

        if (offsetPosition == behindPlanePosition)
        {
            transform.position = plane.transform.position + offsetPosition;
            transform.LookAt(plane.transform);
        }

        if (offsetPosition == rightOfPlanePosition)
        {
            transform.position = plane.transform.position + offsetPosition;
            transform.eulerAngles = rightOfPlaneRotation;
        }     
        
    }
}
