using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonController : MonoBehaviour
{
    //variables
    public int scoreIncrease = 100;
    public int clicksToPop = 3;
    public int totalScore;
    public float scaleUp = .25f;
    public ScoreManager redScoreManager; //references the ScoreManager script
    public float upperBound = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

        //reference ScoreManager component so that it applies to all prefabs
        // here we are saying that the script that we have declared in the variables above is the same that is attached to this object
        redScoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
   
    }

   

    //balloon when clicked
    private void OnMouseDown()
    {
        //reduce clicks needed to pop
        clicksToPop -= 1;

        //inflate when clicked
        transform.localScale += Vector3.one * scaleUp;


        if (clicksToPop == 0)
        {
            //references score manager script and it's increase score text fucntion. Increases by score increase int. declared here
            redScoreManager.IncreaseScoreText(scoreIncrease);
            Destroy(gameObject);
        }
      
    }
    
}
