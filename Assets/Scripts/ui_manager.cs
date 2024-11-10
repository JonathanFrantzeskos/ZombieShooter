using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UIElements;

public class ui_manager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text restartText;
    
    public bool isGameOver = false; //why was it private???

    void Start()
    {
        //Disabel panel if visibles
        gameOverPanel.SetActive(false);
        restartText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Trigger game over manually and check with bool so it isn't called multiple times
        if (Input.GetKeyDown(KeyCode.G) || isGameOver)
        {
            isGameOver = true;
            
            StartCoroutine(GameOverSequence());
        }
    
        if (isGameOver){
            //If R is hit, restart the current scene
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale =1;
            }
            
            //If Q is hit, quit the game
            if (Input.GetKeyDown(KeyCode.Q))
            {
                print("Application Quit");
                Application.Quit();
            }
        }
    }
    //controls game over canvas and there's a brief delay between main Game Over text and option to restart/quit text
    public IEnumerator GameOverSequence()
    {
        Time.timeScale =0 ; //pause the game
        gameOverPanel.SetActive(true);
        
        yield return new WaitForSecondsRealtime(.50f); //"real time" so that timescale doesnt affect it

        restartText.gameObject.SetActive(true);
         
    }
}
