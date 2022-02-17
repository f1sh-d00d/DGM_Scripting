using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour


{
    //array declarations
    public string[] friendNames = { "Abed", "Troy", "Brita", "Jeff", "Annie", "Shirley", "Pierce" };
    //                             {   0,      1,      2,      3,      4,        5,         6}

    public int[] numbers = { 1, 2, 3, 4, 5, 6 };
    public string[] weaponNames = { "shadows bane", "storm bringer", "the mouse", "literally a spatula", "gyallandor", "the boot" };
    public int[] multiplesOfTen = { 10, 20, 30, 40, 50, 60 };
    public string[] carBrands = { "tesla", "ford", "bugatti", "ferrari", "nissan" };
    public string[] bandNames = { "AWOLNATION", "The Scorpions", "Nirvana", "Outkast", "Wu-Tang Clan" };
    public string[] sciFiMovies = { "Alien", "Star Trek", "Dune", "Interstellar", "Tron" };
    public string[] heroes = { "Batman", "Daredevil", "Spiderman", "Wolverine", "Blue Beetle", "Captain America", "Luke Cage", "Dr. Fate" };
    public string[] candy = { "skittles", "Sour Patch Kids", "Reeses", "Hersheys Bar", "heath" };
    public string[] NYCbarrios = { "Crown Heights", "Hells Kitchen", "Harlem", "Jamaica", "Inwood", "SoHo" };

    // Start is called before the first frame update
    void Start()
    {
        // reading whole arrays

        /*
        foreach (string friendNames in friendNames)
        {
            Debug.Log(friendNames);
        }
        foreach (int numbers    in  numbers)
        {
            Debug.Log(numbers);
        }
        foreach(string weaponNames in weaponNames)
        {
            Debug.Log(weaponNames);
        }
        foreach(int multiplesOfTen in multiplesOfTen)
        {
            Debug.Log(multiplesOfTen);
        }
        foreach (string carBrands in carBrands)
        {
            Debug.Log(carBrands);
        }
        foreach(string bandNames in bandNames)
        {
            Debug.Log(bandNames);
        }
        */

        Debug.Log(heroes[1] + " watches over " + NYCbarrios[1]);
        Debug.Log("One of my favorite movies of all time is " + sciFiMovies[0]);
        Debug.Log("The " + bandNames[4] + " is from " + NYCbarrios[0] + " and " + NYCbarrios[2]);
        Debug.Log("If I had to fight a demon, I would use a " + carBrands[0] + " and " + weaponNames[3]);

        //read specific variables in the array
        //Debug.Log(bandNames[1]);

     
    }

  
}
  