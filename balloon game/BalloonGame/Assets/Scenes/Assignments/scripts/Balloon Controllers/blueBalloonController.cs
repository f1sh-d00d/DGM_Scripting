using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBalloonController : MonoBehaviour

   
{
    public int clickToPop = 2;
    public float sizeIncrease = .25f;
    public int blueScoreIncrease = 50;
    public int totalScore;
    public ScoreManager blueScoreManager;
    public float blueUpperBound = 3.0f;

    //see greenBallonController for all comments

    // Start is called before the first frame update
    void Start()
    {
        blueScoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

  

    private void OnMouseDown()
    {
        clickToPop -= 1;
        transform.localScale += Vector3.one * sizeIncrease;

        if(clickToPop==0)
        {
            blueScoreManager.IncreaseScoreText(blueScoreIncrease);
            Destroy(gameObject);
        }
    }
}
