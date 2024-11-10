using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthcontroller : MonoBehaviour
{
    public int Health;
    [SerializeField] private Image[] hearts;
    public int counting_lives=0;
    public ui_manager manager;

    void Start(){
        UpdateHealth();
    }
    
    public void UpdateHealth(){
        counting_lives = 0;
        for(int i =0; i < hearts.Length;i++)
        {
            if(i<Health){
                hearts[i].color = Color.red;
            }
        
            else {
            hearts[i].color = Color.black;
            counting_lives+=1;
            }
        }
        if (counting_lives == 3){ 
            manager.isGameOver = true; //activates death menu
            ScoreKeeper.Score = 0; //restart score after death
            
        }
        

        
    }
}
