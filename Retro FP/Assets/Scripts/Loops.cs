using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int birdsOnLine = 12;
    public int survivors = 36;
    public int days;
    public float deci = 1f;
    public int evenNums = 2;
    public int oddNums = 1;
    public int Dragons = 2600;
    public float startHealth = 75;
    public float moneyInBank = 10000;
    public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 1; i < numEwoks; i++)
        {
            Debug.Log("There are " + i + "  Ewoks on a log");
        }
        

        while(birdsOnLine < 12)
        {
            Debug.Log(birdsOnLine);
            Debug.Log("All the birds have flown south for the winter");
            birdsOnLine++;
        
        }

        for (int i = survivors; i > 0; i--)
        {
            Debug.Log("there are " + i + " survivors on the island");
        }

        for(int i = 0; i <100; i ++)
        {
            Debug.Log("It has been " + i + " days without contact");
        }

        while (moneyInBank < 50000)
        {
            Debug.Log("you have $"+moneyInBank+" in the bank");
            moneyInBank += (moneyInBank * (1 / 4));
        }

        while (deci < 2.5f)
        {
            Debug.Log(deci);
            deci += 0.5f;
        }

        while (startHealth > maxHealth)
        {
            Debug.Log("health:" + startHealth + " - You do not have full health");
            startHealth += 5f;
        }

        for(int i = evenNums; i > 10; i+=2)
        {
            Debug.Log(i);
        }

        while(oddNums < 9)
        {
            Debug.Log(oddNums);
            oddNums += 2;
        }

        for (int i = 0; i < Dragons; i += 100)
        {
            Debug.Log("There are "+ i+ "dragons. Dragons are still endangered.");
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
