using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Player Health")]
    public int curHP; // players current HP
    public int maxHP; // max HP player can have
    public HealthBar healthBar;

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

    [Header("Inventory")]
    public int key;
    public int coins;
    public int gems;
    public int ammo;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // references Rigidbody2D component
        curHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for L R movement
        movement.y = Input.GetAxis("Vertical"); // input for Up Down movement
        if (Input.GetKeyDown(KeyCode.L)) // L for attack
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

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime); //references postion, controls(from update), and finally movement per second
        UpdateDirection();
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer); //set the place where the attack lands
      
        if (hit.collider != null)//checks to make sure the player isn't hiting nothing
        {
            hit.collider.GetComponent<EnemyManager>()?.TakeDamage(damage);
        }
    }
    public void Die() // destroys character sprite if health = 0
    {
        Debug.Log("Player has... transcneded");
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage; //lowers HP variable
        healthBar.SetHealth(curHP); //updates health bar using current HP

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