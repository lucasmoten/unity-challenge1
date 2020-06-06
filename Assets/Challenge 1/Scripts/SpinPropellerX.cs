using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 2400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Plane and child Propeller facing forward so we can rotate around that
        transform.Find("Propeller").Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
