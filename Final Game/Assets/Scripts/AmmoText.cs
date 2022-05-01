using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoText : MonoBehaviour
{

    public int ammoAmt; //keeps track of score
    public TextMeshProUGUI ammoText; //text in score bar



    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoText(); //updates score to 0 at beginning of game

    }

    public void IncreaseAmmoText(int amount) //function that can be called upon to increase score
    {
        ammoAmt += amount; // += compunds amount
        UpdateAmmoText(); // references update text function
    }

    public void UpdateAmmoText() // funtion that can be called upon to update score text
    {
        ammoText.text = "Ammo: " + ammoAmt;

    }

    public void DecreaseAmmoText(int amount) //function that can be called on to reduce points
    {
        ammoAmt -= amount;
        UpdateAmmoText();
    }
}
