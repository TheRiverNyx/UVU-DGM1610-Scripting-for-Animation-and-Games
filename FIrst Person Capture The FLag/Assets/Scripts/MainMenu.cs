using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneToLoad;
    
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);//loads first level
        Debug.Log("New scene loaded!");
    }

    public void QuitGame()
    {
        Application.Quit();//Quits the game
        Debug.Log("You have quit the game!");
    }
    
}