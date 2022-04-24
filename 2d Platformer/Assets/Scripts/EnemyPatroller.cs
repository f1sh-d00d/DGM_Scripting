using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatroller : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveRight = true;
    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //moves object right

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        if(groundInfo.collider == false)
        {
            if(moveRight == true)
            {
                //flip enemy to move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;

            }
            else
            {
                //flip back right
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveRight = true;

            }
        }
            
    }
}
