using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour



{/*
    enum Color { red, orange, green, blue, purple };
    enum CarMake { ford, toyota, dodge };
    enum CarModel { Mustang, Tacoma, Charger};
    enum cheeses { gouda, cheddar, swiss, provolone, pepperJack };
    enum bread { wheat, white, rye, wholeGrain, sourdough, baguette };
    enum meats { chicken, turkey, roastBeef, pastrami, bacon, none};
    enum toppings { lettuce, tomato, avacado, spinach, cucumber, pickles, sauerkraut, tomatoAndLettuce, none};
    enum sauce { ranch, mayo, mustard, specialSauce, oneKThouIsland, auJus, none};
    enum sandwhich {rueben, blt, turkey, turkeyAvacado, frenchDip, roastBeef, grilledCheese}
    enum sides { fries, chips, friedPickles, muffin, cookie, salad}

    public int sandy;

    // Start is called before the first frame update
    void Start()
    {
        Color Paint;
        Paint = Color.blue;

        Debug.Log(Paint);

        CarMake make;
        CarModel model;

        make = CarMake.dodge;
        model = CarModel.Charger;

        Debug.Log("Car Manufacture: " + make + "Car Model: " + model);

        Recall(CarMake.toyota, CarModel.Tacoma);
        cheeses sandCheese;
        bread sandBread;
        meats sandMeat;
        toppings sandTop;
        sauce sandSauce;
        sandwhich sammy;
        sides side;

        MakeSandwhich(cheeses.swiss, bread.rye, meats.pastrami, toppings.sauerkraut, sauce.oneKThouIsland);
        ComboMeal(sandwhich.rueben, sides.cookie);
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.dodge && model == CarModel.Charger)
        {
            Debug.Log("Recall enacted on your vehicle due to brake line issue. Please take car to nearest Dealer.");
        }
        else if(make == CarMake.ford && model == CarModel.Mustang)
        {
            Debug.Log("sicko mode");
        }
        else
        {
            Debug.Log("No Recall");
        }
    }
    void MakeSandwhich(cheeses sandCheese, bread sandBread, meats sandMeat, toppings sandTop, sauce sandSauce)
    {
        if(sandCheese==cheeses.provolone && sandBread==bread.white && sandMeat==meats.bacon && sandTop==toppings.tomatoAndLettuce && sandSauce==sauce.mayo)
        {
            Debug.Log("you have made a BLT");
        }
        else if (sandCheese == cheeses.swiss && sandBread == bread.rye && sandMeat == meats.pastrami && sandTop == toppings.sauerkraut && sandSauce == sauce.oneKThouIsland)
        {
            Debug.Log("you have made a rueben");
        }
        else if(sandCheese == cheeses.provolone && sandBread == bread.white && sandMeat == meats.bacon && sandTop == toppings.tomatoAndLettuce && sandSauce == sauce.mayo)
        {
            Debug.Log("you have made a BLT");
        }
        else if(sandCheese == cheeses.provolone && sandBread == bread.baguette && sandMeat == meats.roastBeef && sandTop == toppings.none && sandSauce == sauce.auJus)
        {
            Debug.Log("you have made a french dip");
        }
        else if(sandCheese == cheeses.provolone && sandBread == bread.sourdough && sandMeat == meats.turkey && sandTop == toppings.avacado && sandSauce == sauce.mayo)
        {
            Debug.Log("you have made a turkey avacado");
        }
        else if(sandCheese == cheeses.provolone && sandBread == bread.white || sandBread==bread.wheat && sandMeat == meats.turkey && sandTop == toppings.tomatoAndLettuce && sandSauce == sauce.mayo)
        {
            Debug.Log("you have made a BLT");
        }
        else if(sandCheese == cheeses.cheddar && sandBread == bread.white || sandBread==bread.wheat && sandMeat == meats.none && sandTop == toppings.none && sandSauce == sauce.none)
        {
            Debug.Log("you have made a grilled cheese");
        }
        else
        {
            Debug.Log("I don't know what this is");
        }

    }
    void ComboMeal(sandwhich sammy, sides side)
    {
        if (sammy == sandwhich.blt && side == sides.chips)
        {
            Debug.Log("pretty classic combo");
        }
        else if (sammy == sandwhich.frenchDip && side == sides.friedPickles)
        {
            Debug.Log("kind of a strange combo");
        }
        else if (sammy == sandwhich.grilledCheese && side == sides.fries)
        {
            Debug.Log("another solid choice");
        }
        else if (sammy == sandwhich.turkeyAvacado && side == sides.salad) 
        {
            Debug.Log("feelin healthy");
        }
        else if(sammy==sandwhich.turkey && side==sides.cookie)
        {
            Debug.Log("subway stereotype");
        }
        else
        {
            Debug.Log("nice choice");
        }
    }*/
}
