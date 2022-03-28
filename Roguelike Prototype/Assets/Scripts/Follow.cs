using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();// finds player position
        speed = 2.0f;
        stopDistance = 1.5f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stopDistance)// moves enemy closer to player, until a certain stopping point
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
