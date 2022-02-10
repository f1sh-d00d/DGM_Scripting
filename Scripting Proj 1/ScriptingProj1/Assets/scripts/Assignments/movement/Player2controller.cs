using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controller : MonoBehaviour
{
    //speeds
    public int speed = 25;
    private int turnSpeed = 200;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if(Input.GetKey("left"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if(Input.GetKey("right"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
