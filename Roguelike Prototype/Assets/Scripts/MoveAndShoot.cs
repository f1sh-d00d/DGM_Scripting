using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;//how close enemy can get to player
    public float retreatDistance;//how close player can get before enemy back away
    public Transform target; // saves position of Player
    private float shotDelay;
    public float startDelay;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();// finds player position
        shotDelay = startDelay;
        speed = 1.5f;
        stopDistance = 4.0f;
        retreatDistance = 2.0f;
        startDelay = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stopDistance)// if player outside of stopping distance, move towards player
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        else if (Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)// if player within stopping distnace, but not retreat distance, then stay put
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);// if plater is within retreat distance, then retreat
        }

        if (shotDelay <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);// fire/instantiate projectile on a cycle
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
    }
}
