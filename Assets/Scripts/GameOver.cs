using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public Player thePlayer;
    public ScoreManager sm;
    

    void Start()
    {
        thePlayer = FindObjectOfType<Player>();
        sm = FindObjectOfType<ScoreManager>();
    }

    
    void Update()
    {
        if(thePlayer.health == 0){
            gameOver.SetActive(true);
            Destroy(thePlayer.gameObject);
            sm.scoreIncreasing = false;

        }
    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        thePlayer.health = 3;
        sm.scoreIncreasing = true;
    }

    public void BackToMainMenu()
    {

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
