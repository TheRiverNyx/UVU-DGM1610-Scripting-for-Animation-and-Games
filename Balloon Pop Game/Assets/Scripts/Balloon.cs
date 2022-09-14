using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop=3;//how many clicks until the balloon pops

    public float scaleToInflate = 0.10f;//the scale amount a balloon inflates each time it is clicked.

    public int scoreToGive = 100;
    
    private ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //reference ScoreManager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        clickToPop -= 1;//Reduce clicks by one
        //inflate the balloon every click by a percentage
        transform.localScale+=Vector3.one*scaleToInflate;
        //destroy game object if clickToPop is equal to 0
        if (clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);//Send points to score manager and update the score
            
            Destroy(gameObject);//destroy this balloon
        }
    }
}
