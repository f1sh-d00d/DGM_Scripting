using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
    
{
    public int hitsToBreak = 3;
    public GameObject ammoPickup;

    private void Start()
    {
        ammoPickup = GameObject.Find("Ammo Pickup");
    }
    // Update is called once per frame
    void Update()
    {
        if(hitsToBreak == 0)
        {
            Break();
        }
    }

    public void Break()
    {
        Instantiate(ammoPickup, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void TakeDamage()
    {
        hitsToBreak -= 1;
    }
}
