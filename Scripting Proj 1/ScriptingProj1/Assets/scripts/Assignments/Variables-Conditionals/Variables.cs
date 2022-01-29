using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
    //Global Variables
    
{
   public int money;
   public int health;
   public float water;
   public int ammunition;
   public bool isDay = true;
   public string LoginName = "wakaflocka";

    // Start is called before the first frame update
    void Start()
    {
        money = 175;
        Debug.Log("wallet: $" + money);
        health = 100;
        ammunition = 250;
        Debug.Log("Ammo:" + ammunition);
        water = 128f;
        Debug.Log("water (oz.)" + water);
        if(LoginName == "wakaflocka")
        {
            Debug.Log("logged in and ready to roll");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDay)
        {
            Debug.Log("the sun is up");
        }
        else if (isDay == false)
        {
            Debug.Log("the sun is down");
        }
        if (water <= 49.9)
        {
            Debug.Log("drink up");
        }
        if(ammunition <= 40)
        {
            Debug.Log("reload");
        }
        if(money < 60)
        {
            Debug.Log("ur poor brother");
        }
        else if (money >= 61)
        {
            Debug.Log("spend on!");
        }
        if (health >= 100)
        {
            Debug.Log("you are in perfect health");
        }
        else if (health >= 75 && health <= 99)
        {
            Debug.Log("you are doing fine");
        }
        else if(health >= 50 && health <= 74)
        {
            Debug.Log("you are not doing as fine");
        }
        else if(health >= 25 && health <= 49)
        {
            Debug.Log("you are definitely now in bad shape");
        }
        else if(health >= 1 && health <= 24)
        {
            Debug.Log("x_x");
        }
    }
}
