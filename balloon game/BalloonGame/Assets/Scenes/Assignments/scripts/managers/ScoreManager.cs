using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int score; //keeps track of score
    public TextMeshProUGUI scoreText; //text in score bar
    


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText(); //updates score to 0 at beginning of game

    }

    public void IncreaseScoreText(int amount) //function that can be called upon to increase score
    {
        score += amount; // += compunds amount
        UpdateScoreText(); // references update text function
    }

    public void UpdateScoreText() // funtion that can be called upon to update score text
    {
        scoreText.text = "Score: " + score;

    }

    public void DecreaseScoreText(int amount) //function that can be called on to reduce points
    {
        score -= amount;
        UpdateScoreText();
    }

    
}
