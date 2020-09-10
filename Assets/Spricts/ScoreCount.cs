using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text Score;
    int score = 0;
    public void AddScore()
    {
        score++;
        Score.text = $"倒したサル {score:00} 匹";
    }
    public void DiffScore()
    {
        score--;
        Score.text = $"倒したサル {score:00} 匹";
    }
}
