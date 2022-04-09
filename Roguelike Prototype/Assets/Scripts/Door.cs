using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private PlayerController playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && playerScript.key == 1)
        {
            Debug.Log("You have opened the door");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Door is locked. Find a key");
        }
    }
}
