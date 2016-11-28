using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

 
    public GameObject panel; //panel is the Pause Menu
    //GameObject player;
    public MonoBehaviour[] Scripts;

    bool paused = false;

    // Use this for initialization
    void Start() {
        panel.gameObject.SetActive(false);
        //Time.timeScale = 1;
    }

    
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!paused)
            {
                // player = GameObject.Find("PlayerBall");
                Time.timeScale = 0;
                panel.gameObject.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                /* foreach (MonoBehaviour thisScript in Scripts)
                  {
                      thisScript.enabled = false;
                  } */
                paused = true;


               
            }
            else
            {
                Time.timeScale = 1;
                panel.gameObject.SetActive(false);
                /* foreach (MonoBehaviour thisScript in Scripts)
                 {
                     thisScript.enabled = true;
                 }
                */
                paused = false;

            }
        }
	}
    public void Continue()
    {
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);

    }
}
