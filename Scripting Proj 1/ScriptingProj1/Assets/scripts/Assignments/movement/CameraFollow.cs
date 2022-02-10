using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player1;
    private Vector3 offset = new Vector3(0, 2.5f, -7);


    void Update()
    {
        // follow player 1
        //transform.position = Player1.transform.position+offset;
    }
}
