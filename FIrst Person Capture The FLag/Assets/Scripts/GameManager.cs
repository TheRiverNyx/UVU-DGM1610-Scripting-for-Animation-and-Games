using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int mainMenu;
    [Header("UI Options")] 
    public GameObject haveFlag;
    public GameObject youWonText;
    public GameObject youLostText;
    [Header("Flag Status")]
    public bool hasFlag;
    public bool flagPlaced;
    public bool gameOver = false;
    public float slowDownTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;
        //disable some ui elements until activated
        youLostText.SetActive(false);
        youWonText.SetActive(false);
        haveFlag.SetActive(false);
        //flag bools
        hasFlag = false;
        flagPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasFlag)
        {
            haveFlag.SetActive(true);
        }
        if (flagPlaced)
        {
            WinGame();
        }
        if (gameOver)
        {
            if (slowDownTime <= 0)
            {
                SceneManager.LoadScene(mainMenu);
            }
            else
            {
                slowDownTime -= Time.fixedDeltaTime;
            }
        }
        
    }

    void WinGame()
    {
        gameOver = true;
        youWonText.SetActive(true);
        Time.timeScale = 0.25f; //slows down the game
        Time.fixedDeltaTime = 0.02f * Time.timeScale;//makes slow motion load smoothly
    }
    public void PlaceFlag()//places the flag on the pedastal
    {
        hasFlag = false;
        flagPlaced = true;
    }
}
