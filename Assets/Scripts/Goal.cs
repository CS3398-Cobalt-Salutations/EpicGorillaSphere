using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Goal : MonoBehaviour
{
    public string nextSceneName;
    public LoadSceneMode sceneMode;
    public bool requireAllPlayers;

    private List<int> playersInZone;
    private int numPlayers;

    void Start()
    {
        playersInZone = new List<int>();
        numPlayers = Object.FindObjectsOfType<PlayerMoveSphere>().Length;
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            if (!requireAllPlayers)
            {
                NextScene();
            }
            else
            {
                playersInZone.Add(pms.playerNumber);
                if (AllPlayersPresent)
                {
                    NextScene();
                }
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            playersInZone.Remove(pms.playerNumber);
        }
    }

    private void NextScene()
    {
        SceneManager.LoadScene(nextSceneName, sceneMode);
    }

    private bool AllPlayersPresent { get { return playersInZone.Count == numPlayers; } }
}
