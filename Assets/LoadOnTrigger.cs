using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnTrigger : MonoBehaviour
{
    public string Trigger;
    public int LevelNumber;
    Animation Spin;
    Collider Character;
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

        StartCoroutine(VictorySpin(collider));
      
    }

    IEnumerator VictorySpin(Collider collider) {
        
        
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(LevelNumber);
    }
}