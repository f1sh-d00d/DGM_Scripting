using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public int moveSpeed; //speed of movement
    private Rigidbody2D rb; //references the Rigidbody2D on the player
    Vector2 movement; //stores player location and references it for movement
    Vector2 direction;
    
    

    [Header("Attack")]
    public int ammo; //amount of ammo player has
    public int damage; //amount of damage player can deal
    public GameObject playerProjectile;

    [Header("Health")]
    public int maxHp = 5; //maximum potential HP
    public int curHp; //current HP of player

    public EnemyManager enemyManager;
    public AmmoText ammoText;
    public HealthText healthText;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //calls the Rigidbody into the game by getting it from the game object
        curHp = maxHp; //sets the current HP to the max Hp so the player starts the game with maximum potential health
        Cursor.visible = true;
        ammo = 50;
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //sets controls for left right movement
        movement.y = Input.GetAxis("Vertical"); //set controls for up down movement
        
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {
                Fire();
                ammoText.DecreaseAmmoText(ammo);
            }
            else
            {
                Debug.Log("out of ammo");
            }
        }
    }

    private void FixedUpdate() //we put movement in fixed update cuz the physics work better that way
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime); // this takes the players current position, then combines it with the input to move. It multiplies that by movement speed and seconds

    }

    public void Die() // destroys character sprite if health = 0
    {
        Debug.Log("Player has... transcneded");
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        curHp -= 1; //lowers HP variable
        healthText.DecreaseHealthText(1);

        if (curHp <= 0)
            Die();

    }

    public void Attack()
    {
        enemyManager.TakeDamage(1);
    }

    public void Fire()
    {
        Instantiate(playerProjectile, transform.position, Quaternion.identity);
        ammo -= 1;
    }

    
}
