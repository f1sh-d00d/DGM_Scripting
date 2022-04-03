using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour



{
    enum Color { red, orange, green, blue, purple };
    enum CarMake { ford, toyota, dodge };
    enum CarModel { Mustang, Tacoma, Charger};

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
}
