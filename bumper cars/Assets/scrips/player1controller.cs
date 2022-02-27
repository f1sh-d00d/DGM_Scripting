using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1controller : MonoBehaviour
{
    public float moveSpeed = 35.0f;
    public float turnspeed = 210.0f;


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
       if(Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnspeed);
        }
       if(Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
       if(Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);
        }
    }
    
}
