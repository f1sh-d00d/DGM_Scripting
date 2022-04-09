using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerController playerController;

    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;
    
    [Header("Enemy Attack")]
    public float attackRange; //range of enemies of attack
    public float attackRate; //how fast they attack
    public float lastAttackTime;
    public int damage;// damage enemies can deal

    [Header("Loot Drop")]
    public GameObject lootDrop_item;


    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        lootDrop_item = GameObject.Find("Key");
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, playerController.transform.position) < attackRange) 
        {
            Attack();
        }
       
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <=0)
        {
            Die();
            LootDrop();
        }
       
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Attack()
    {
        lastAttackTime = Time.time;
        playerController.TakeDamage(damage);
    }

    void LootDrop()
    {
        Instantiate(lootDrop_item, transform.position, Quaternion.identity);
    }

    
}


