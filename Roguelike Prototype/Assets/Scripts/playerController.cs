using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    [Header("Player Health")]
    public int curHP; // players current HP
    public int maxHP; // max HP player can have


    [Header("Player Movement")]
    public float moveSpeed = 5.0f; //speed of player movement
    private Rigidbody2D rb; //references rigidbody component
    Vector2 movement; //stores players x,y pos movement
    Vector2 direction;


    [Header("Player Combat")]
    public float attackRange; //range of players of attack
    public float attackRate; //how fast they attack
    public float lastAttackTime;
    public int damage;// damage player can deal
    public LayerMask enemyLayer;


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
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(Time.time - lastAttackTime >= attackRate)
            {
                Attack();
            }
            

        }
    }
    void FixedUpdate()
    {
        //Apply physics and move character

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        UpdateDirection();
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);
        if (hit.collider != null)//checks to make sure the player isn't hiting nothing
        {
            hit.collider.GetComponent<enemyManager>()?.TakeDamage(damage);
        }
    }
    public void Die()
    {
        Debug.Log("PLayer has... transcneded");
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if (curHP <= 0)
            Die();

    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if (vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;
    }
}