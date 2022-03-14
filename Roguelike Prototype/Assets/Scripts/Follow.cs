using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed = 2.0f;
    public float stopDistance = 1.5f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();// finds player position
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stopDistance)// moves enemy closer to player, until a certain stopping point
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
