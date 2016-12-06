using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnTrigger : MonoBehaviour
{
    public int LevelNumber;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}