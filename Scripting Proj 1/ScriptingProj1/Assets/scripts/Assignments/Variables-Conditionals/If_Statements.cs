using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
  public string lightColor;
  public string weather;
  public int keys;
  public int power;
    public bool DoYouWieldTheSwordOfPower = false;
    public bool BatSignalOn = true;
    public float GameProgress;

    // Start is called before the first frame update
    void Start()
    {
        keys = 1;
        power = 1;
        lightColor = ("Green");
    }

    // Update is called once per frame
    void Update()
    {
        if (lightColor == "Red")
        {
            Debug.Log("the light is " + lightColor + ". Stop!");
        }

        else if (lightColor == "Yellow")
        {
            Debug.Log("the light is " + lightColor + ". Begin Stopping or Clear Intersection");

        }
        else if (lightColor == "Green")
        {
            Debug.Log("the Light is " + lightColor + ". Go");
        }
        else
        {
            Debug.Log("Wait for repairs");
        }
        if (weather == "rainy" || weather == "snowy")
        {
            Debug.Log("it is cold. wear a coat");

        }
        else if (weather == "windy" || weather == "overcast")
        {
            Debug.Log("a sweater should be okay today");
        }
        else if (weather == "sunny")
        {
            Debug.Log("t-shirt weather!");
        }
        if (keys >= 10 && power >= 30)
        {
            Debug.Log("you can open the dungeon");
        }
        else
        {
            Debug.Log("you cannot open the dungeon");
        }
        if (power >= 10 && keys >= 3)
        {
            Debug.Log("you can open the forest gate");
        }
        else
        {
            Debug.Log("you cannot open the gate");
        }
        if (power >= 1 && keys >= 1)
        {
            Debug.Log("you can open the village chest");
        }
        if (DoYouWieldTheSwordOfPower == true)
        {
            Debug.Log("Congratulations traveller. You are ready to take on The Overlord");
        }
        else
        {
            Debug.Log("you must acquire the Sword of Power to defeat the One");
        }
        if (BatSignalOn == true)
        {
            Debug.Log("Better head out. The City needs saving tonight");
        }
        else
        {
            Debug.Log("Looks like the streets are quiet. For now.");
        }
        if (GameProgress == 3.14f)
        {
            Debug.Log("Trophy Unlocked: Far as Pi");
        }
        if(GameProgress == 100f)
        {
            Debug.Log("Trophy Unlocked: Completer. Big Flex");
        }
        if(GameProgress == 99.99f)
        {
            Debug.Log("Trophy Unlocked: Not Quite There. ");
        }
    }
}