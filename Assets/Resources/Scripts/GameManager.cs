using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("Game States")]
    public bool isPaused;
    public bool isGameOver;

    void Awake()
    {
      if(instance == null) 
      {
        instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else{
        Destroy(gameObject);
        return;
      }
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        //this is where youd put your pause menu
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        //this is where youd turn off your pause menu
    }

    public void GameOver()
    {
        isGameOver = true;
        //this is where you decide what happens at game over
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}