using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Transform player;
    private Vector2 target;
    private EnemyManager enemyManager;
    public float bulletLife = 3.0f;
    public BoxManager boxManager;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>(); //gets location of player
        target = new Vector2(player.position.x, player.position.y); //sets target location to players location
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); //moves projectile towards player
        if (transform.position.x == target.x && transform.position.y == target.y) // code if it hits the enemy
        {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("Player")) //more code if it hits the enemy
        {
            DestroyProjectile();
            enemyManager.Attack(); //refrernces attack function on enemy manager script
        }
        else if (other.CompareTag("Box"))
        {
            DestroyProjectile();
            boxManager.TakeDamage();
        }
        else
        {
            Destroy(gameObject, bulletLife);
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
