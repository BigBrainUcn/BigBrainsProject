using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;

    public float scoreCount;
    public float pointsPerSeconds;

    public bool scoreIncreasing;


    void Start()
    {
        pointsPerSeconds = 1;
    }

    // Update is called once per frame
    void Update()
    {

        scoreCount += pointsPerSeconds * Time.deltaTime;

        scoreText.text = "Score: " + Mathf.Round(scoreCount).ToString();


    }
}
