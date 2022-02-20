using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloonSpawner : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public int balloonIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnRandomBalloon()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-5, 5), -2, 0);
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        Instantiate(balloonPrefabs[balloonIndex], SpawnPos, balloonPrefabs[balloonIndex].transform.Translate.rotation);

    }
}
