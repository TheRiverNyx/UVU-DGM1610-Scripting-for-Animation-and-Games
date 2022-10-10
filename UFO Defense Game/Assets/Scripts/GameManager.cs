using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    private ScoreManager scoreManager;
    // Start is called before the first frame update
    private void Awake()// set game time to normal, set isGameOver to false
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.score < 0)//if the score goes below zero set isGameOver to true
        {
            isGameOver = true;
        }
        if (isGameOver)// If isGameOver is set to true, end the game, if not dont display text
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);//keeps game over text hidden 
        }
    }

    public void EndGame()//freezes game time and displays game over text
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
