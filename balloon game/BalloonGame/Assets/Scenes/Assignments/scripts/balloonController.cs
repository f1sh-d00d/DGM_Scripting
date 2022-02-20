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
    public ScoreManager scoreManager; //references the ScoreManager script

    // Start is called before the first frame update
    void Start()
    {
        //score stuff maybe
        // totalScore = 0;


    }

    // Update is called once per frame
    void Update()
    {
       

    }

    //balloon when clicked
    private void OnMouseDown()
    {
        clicksToPop -= 1;

        transform.localScale += Vector3.one * scaleUp;

        //probably wrong score function
        //totalScore = totalScore + scoreIncrease;
        
        if(clicksToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreIncrease);
            Destroy(gameObject);
        }
        
      
    }
    
}
