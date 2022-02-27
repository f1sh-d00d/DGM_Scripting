using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenBalloonController : MonoBehaviour
{
    public int GreenScoreIncrease = 200;
    public float inflate = .125f;
    public int totalScore;
    public int clicksToPop = 6;
    public ScoreManager greenScoreManger;
    public float greenUpperBound = 3.0f;


    private void Start()
    {
        greenScoreManger = GameObject.Find("Score Manager").GetComponent<ScoreManager>(); //references score manager script
    }

   


    void OnMouseDown() //says "when the mouse clicks, run this:
    {
        clicksToPop -= 1; //reduces clicks until the balloon pops
        transform.localScale += Vector3.one*inflate; //inflates ballon on each click

        if(clicksToPop==0) //when clicks needed to pop = 0
        {
            greenScoreManger.IncreaseScoreText(GreenScoreIncrease); //inceases points using a function from the score manager script, increase by variable above
            Destroy(gameObject); //pops balloon

        }

    }
}
