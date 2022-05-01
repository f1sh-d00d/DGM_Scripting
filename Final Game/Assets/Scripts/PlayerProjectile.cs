using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed;
    private Vector2 target;
    private EnemyManager enemyManager;
    public float bulletLife = 5.0f;
    public PlayerController playerController;
    public Vector2 mouseInput;
    public float mouseSensitivity = 100.0f;
    public BoxManager boxManager;

    // Start is called before the first frame update
    void Start()
    {
        mouseInput = new Vector2(Input.mousePosition.x, Input.mousePosition.y)*mouseSensitivity; //gets mouse position
        //mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        target = mouseInput; //set target postion to mouse position
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
     

        transform.position = Vector2.MoveTowards(transform.position, mouseInput, speed * Time.deltaTime); //tells projectile to move towards mouse position
        
    }

    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("Enemy")) //code if it hits an object with an enemy tag
        {
            DestroyProjectile();
            playerController.Attack();
        }
        else if (other.CompareTag("Box")) //code if bullet hits box
        {
            DestroyProjectile();
            boxManager.TakeDamage();
        }
        else
        {
            Destroy(gameObject, bulletLife); //if it hits anythign else
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}

