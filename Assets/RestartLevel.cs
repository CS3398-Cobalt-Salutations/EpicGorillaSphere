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
    }
    public void restartAtLastCheckpoint()
    {
        //Maaaaaaybe?
    }
}
