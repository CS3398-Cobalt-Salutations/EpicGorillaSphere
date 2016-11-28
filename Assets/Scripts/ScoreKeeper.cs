using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
	public static int lives;

    private int personalScore;
    private static int globalScore;
    
    void Start()
    {
		lives = 5;
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
        scoreText.text = "Score: " + CombinedScore.ToString();
    }

    public int CombinedScore { get { return personalScore + globalScore; } }
}
