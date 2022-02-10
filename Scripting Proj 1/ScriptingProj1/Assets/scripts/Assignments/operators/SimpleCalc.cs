using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
    public int numberA = 55;
    public int numberB = 15;
    public int numberC = 16;
    public float numberD = 55f;
    public float numberE = 5f;
    public float numberF = 11f;

    //math function notation: + - * / %

    // Start is called before the first frame update
    void Start()
    {
        int total;

        total = numberA + numberB;
        Debug.Log(total);
        Debug.Log(numberA + " +" + numberB + " =" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //addition
    void Add()
    {
        int total;
        total = numberA + numberB + numberC;
        Debug.Log(numberA + " + " + numberB + " + " + numberC + " = " + total);
    }
    //multiplaction
    void Multi()
    {
        int total;
        total = numberA * numberB * numberC;
        Debug.Log(numberA + " x " + numberB + " x " + numberC + " = " + total);
    }
    //subtraction
    void Sub()
    {
        float total;
        total = numberD - numberE - numberF;
        Debug.Log(numberD + " - " + numberE + " - " + numberF + " = " + total);

    }
    //division with float decimal 
    void Div()
    {
        float total;
        total = numberF / numberE;
        Debug.Log(numberF + " / " + numberE + " = " + total);
    }
    //division without decimal/float, but with remainder
    void Div2()
    {
        int total;
        int rem;
        total = numberA / numberC;
        rem = numberA % numberC;
        Debug.Log(numberA + " / " + numberC + " = " + total);
        Debug.Log("Remainder" + rem);

    }
}
