using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerController playerController;

    [Header("Enemy Health")]
    public int curHP;
    public int maxHP = 2;

    [Header("Enemy Attack")]
    public float attackRange; //range of enemies of attack
    public float attackRate; //how fast they attack
    public float lastAttackTime;
    public int damage;// damage enemies can deal

    [Header("Loot Drop")]
    public GameObject healthPickup;

    public Door door;

    private void Start()
    {
        curHP = maxHP;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        healthPickup = GameObject.Find("Health Pickup");

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
        curHP -= 1;

        if (curHP <= 0)
        {
            Die();
            LootDrop();
        }

    }

    public void Die()
    {
        Destroy(gameObject);
        door.enemiesToUnlock -= 1;
    }

    public void Attack()
    {
        lastAttackTime = Time.time;
        playerController.TakeDamage(1);
    }

    void LootDrop()
    {
        Instantiate(healthPickup, transform.position, Quaternion.identity);
    }

}
