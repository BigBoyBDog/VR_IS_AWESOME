using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SphereScore : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text ="Score: " + score;
    }
}
