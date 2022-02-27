using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 3.0f;
    public ScoreManager moveScoreManager;
    public balloonController RedBalloon;
    public blueBalloonController blueBalloon_;
    public greenBalloonController greenBalloon_;
    public int pointsLost = 100;

    // Start is called before the first frame update
    void Start()
    {
        moveScoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>(); //refrerences score manager
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed); //moves balloon up

        if(gameObject.transform.position.y > upperBound) //if balloon passes upper bound, lose points then destroy balloon
        {
            moveScoreManager.DecreaseScoreText(pointsLost);
            Destroy(gameObject);
        }
   
    }
}
