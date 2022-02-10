using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private int speed =25;
    private int turnSpeed = 200;
    private float hInput;
    private float fInput;


    // Update is called once per frame
    void Update()
    {
        //sets key input

        /*
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // moves car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
        */


        //personal: potential alternate controls
        
        if(Input.GetKey("a"))
        {
            transform.Rotate (Vector3.down*Time.deltaTime*turnSpeed);
        }
        if(Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if(Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        }
    }
}
