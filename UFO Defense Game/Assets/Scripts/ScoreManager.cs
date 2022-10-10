using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;//store score value

    public TextMeshProUGUI scoreText;//reference visual text GUI

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    public void IncreaseScore(int amount)//awards points
    {
        score += amount;//add amount to score
        UpdateScoreText();//update score ui texts
    }

    public void DecreaseScore(int amount)//takes away points
    {
        score -= amount;//subtract amount from score
        UpdateScoreText();//update score ui texts
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score:" + score;
    }
}
