using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; //speed of player movement
    private Rigidbody2D rb; //references rigidbody component
    Vector2 movement; //stores players x,y pos movement

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // references Rigidbody2D component

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for L R movement
        movement.y = Input.GetAxis("Vertical"); // input for Up Down movement
    }
    void FixedUpdate()
    {
        //Apply physics and move character

        rb.MovePosition(rb.position+movement*moveSpeed*Time.deltaTime);


    }
}
