using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSeconds;

    public bool scoreIncreasing;


    void Start()
    {
        pointsPerSeconds = 1;

        if(PlayerPrefs.HasKey("HighScore") != null)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {

       if(scoreIncreasing)
       {
         scoreCount += pointsPerSeconds * Time.deltaTime;
       }

       if(scoreCount > hiScoreCount)
       {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
       } 

        scoreText.text = "Score: " + Mathf.Round(scoreCount).ToString();
        highScoreText.text = "HighScore: " + Mathf.Round(hiScoreCount).ToString();
        



    }
}
