using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int enemiesToUnlock;
    // Start is called before the first frame update
    void Start()
    {
        enemiesToUnlock = 4; //enemies needed destroyed in order to open door is set equal to enemies in the room
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesToUnlock == 0) //once all enemies are destroyed, the door opens
        {
            Destroy(gameObject);
        }
    }
}
