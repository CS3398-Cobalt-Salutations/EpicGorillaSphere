using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public Rect lifeDisplayArea;
    public Texture lifeImage;

    private int lives;
    private GUIStyle textStyle;

    public int Lives
    {
        get { return lives; }
        set { lives = value; CheckForDeath(); UpdateLivesDisplay(); }
    }

    // Use this for initialization
	void Start()
    {
        textStyle = new GUIStyle();
        textStyle.fontSize = 28;
        Lives = 5;
    }

    private void CheckForDeath()
    {
        if (Lives <= 0)
        {
            Keyring.ClearGlobalKeys();
            ScoreKeeper.ClearGlobalScore();
            SceneManager.LoadScene("OpeningScreen");
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(lifeDisplayArea.x - 110, lifeDisplayArea.y + 30, lifeDisplayArea.width, lifeDisplayArea.height), string.Format("Lives: {0:0} x ", Lives), textStyle);
        GUI.DrawTexture(lifeDisplayArea, lifeImage);
    }

    private void UpdateLivesDisplay()
    {
    }
}
