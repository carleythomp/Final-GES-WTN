using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        UpdateText();
        if(score == 6)
        {
            scoreText.text = "Good job!";
        }
    }
    public void UpdateText()
    {
        scoreText.text = $"Score: {score}";
    }
}
