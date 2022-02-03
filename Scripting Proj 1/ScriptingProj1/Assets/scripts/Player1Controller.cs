using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private float speed = 50.0f;
    private float turnSpeed = 300.0f;
    private float hInput;
    private float fInput;
    //public KeyCode left;


    // Update is called once per frame
    void Update()
    {
        //sets key input
        
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // moves car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
        


        //personal: potential alternate controls
        /*
        if(Input.GetKey="a")
        {
            transform.Translate (-1, 0, 0);
        }
        */

    }
}
