using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Controller")]
    public float speed;
    public float jumpHeight;
    private bool isGrounded;
    private Rigidbody2D rb;
    float moveVelocity = 0f; //non-stick player. prevents us from sliding

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius;//determines how far we check for ground
    public LayerMask whatIsGround;//identifies objects with layer "ground"

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //ground check sensor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        

        if (Input.GetKey(KeyCode.D)) //moves us right
        {
            moveVelocity = speed;
        }

        if(Input.GetKey(KeyCode.A))//moves us left
        {
            moveVelocity = -speed;// - = left
        }

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);

    }
}
