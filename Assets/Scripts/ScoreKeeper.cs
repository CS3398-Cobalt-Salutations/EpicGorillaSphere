using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;

    private int availableScore;
    private int personalScore;
    private static int globalScore;
    
    void Start()
    {
        availableScore = GameObject.FindObjectsOfType<Collectible>().Length;
        personalScore = 0;
        UpdateScoreDisplay();
    }

    public static int GetGlobalScore()
    {
        return globalScore;
    }

    public static void UpdateGlobalScore(int value)
    {
        globalScore += value;
        ScoreKeeper[] scoreHolders = Object.FindObjectsOfType<ScoreKeeper>();
        foreach (ScoreKeeper holder in scoreHolders)
        {
            holder.UpdateScoreDisplay();
        }
    }
    public int GetPersonalScore()
    {
        return personalScore;
    }

    public void UpdatePersonalScore(int value)
    {
        personalScore += value;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText == null) return;
        scoreText.text = "Score: " + CombinedScore.ToString() + " / " + availableScore.ToString();
    }

    public int CombinedScore { get { return personalScore + globalScore; } }
}
