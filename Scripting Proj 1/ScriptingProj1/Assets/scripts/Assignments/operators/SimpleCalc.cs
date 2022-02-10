using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
    public int numberA = 55;
    public int numberB = 15;
    public int numberC = 16;


    // Start is called before the first frame update
    void Start()
    {
        int total;

        total = numberA + numberB;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
