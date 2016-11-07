using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{
    public int value;
    public bool isGlobal;
    
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        ScoreKeeper score = other.GetComponent<ScoreKeeper>();
        if (score != null)
        {
            if (isGlobal)
            {
                ScoreKeeper.UpdateGlobalScore(value);
            }
            else
            {
                score.UpdatePersonalScore(value);
            }
            Destroy(gameObject);
        }
    }
}
