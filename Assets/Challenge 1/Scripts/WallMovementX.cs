using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovementX : MonoBehaviour
{
    private float ymax = 60;
    private float ymin = 44;
    private float ydir = -1;
    private float speed = 10;
    private float distance = 25;

    // Start is called before the first frame update
    void Start()
    {
        // Adjust the offset of Obstacle1A from Obstacle1B
        transform.Find("Obstacle1A").transform.Translate(Vector3.up * -1 * distance);

        // TODO: Make ydir random at start
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.Find("Obstacle1B").transform.position.y >= ymax)
        {
            ydir = -1;
        }
        if (transform.Find("Obstacle1B").transform.position.y <= ymin)
        {
            ydir = 1;
        }

        transform.Find("Obstacle1A").transform.Translate(Vector3.up * ydir * speed * Time.deltaTime);
        transform.Find("Obstacle1B").transform.Translate(Vector3.up * ydir * speed * Time.deltaTime);

    }
}
