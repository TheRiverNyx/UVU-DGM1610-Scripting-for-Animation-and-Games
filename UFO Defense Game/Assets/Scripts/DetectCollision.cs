using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollision : MonoBehaviour
{
    
    private ScoreManager scoreManager;//reference the score manager

    public int scoreToGive;//sets the score that UFOs will give
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);//Increase score amount by scoreToGive
        Destroy(gameObject);//Destroy this game object
        Destroy(other.gameObject);//destroys the object that hits the object
    }
}
