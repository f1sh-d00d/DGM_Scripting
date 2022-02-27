using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    //public int balloonIndex;
    public float startDelay = 0.25f;
    public float spawnInterval = 1.5f;
    


    // Start is called before the first frame update
    void Start()
    {
        //determines the rate that a function is run - InvokeRepeating("desired function", how long you want to delay the first function, how long you want between each subsequent function)
        InvokeRepeating("spawnRandomBalloon", startDelay, spawnInterval);
        
    }

 

    void spawnRandomBalloon()
    {
        // get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-3, 3), -3, 0);

        //selects a ballon from the array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        //spawns ballon selected from ballon index in the location determined by spawnPos
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
