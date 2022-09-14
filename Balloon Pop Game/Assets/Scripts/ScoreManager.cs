using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;//the score

    public TextMeshProUGUI scoreText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount;//increase score by certain amount
        UpdateScoreText();
    }
    
    public void DecreaseScoreText(int amount)
    {
        score -= amount;//increase score by certain amount
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
