using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerController player;

    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;
    
    [Header("Enemy Attack")]
    public float attackRange; //range of enemies of attack
    public float attackRate; //how fast they attack
    public float lastAttackTime;
    public int damage;// damage enemies can deal


    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange) 
        {
            Attack();
        }
       
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <=0)
           Die();
       
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }

    
}


