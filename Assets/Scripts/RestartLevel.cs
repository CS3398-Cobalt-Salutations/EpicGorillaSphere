using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Restarts Level to beginning
    public void Restart()
    {
        StartCoroutine(FadeToRestart());
    }

    IEnumerator FadeToRestart()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Keyring.ClearGlobalKeys();
        ScoreKeeper.ClearGlobalScore();
    }

    public void restartAtLastCheckpoint()
    {
        //Maaaaaaybe?
        PlayerMoveSphere[] pms = FindObjectsOfType<PlayerMoveSphere>();
        foreach (PlayerMoveSphere p in pms)
        {
            SaveAndLoad.LoadState(p);
        }
    }
}
