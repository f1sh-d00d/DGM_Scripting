using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthText : MonoBehaviour
{
    public int healthAmt; //keeps track of score
    public TextMeshProUGUI healthText; //text in score bar



    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthText(); //updates score to 0 at beginning of game

    }

    public void IncreaseHealthText(int amount) //function that can be called upon to increase score
    {
        healthAmt += amount; // += compunds amount
        UpdateHealthText(); // references update text function
    }

    public void UpdateHealthText() // funtion that can be called upon to update score text
    {
        healthText.text = "Health: " + healthAmt;

    }

    public void DecreaseHealthText(int amount) //function that can be called on to reduce points
    {
        healthAmt -= amount;
        UpdateHealthText();
    }
}