using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{
    public int value;
    public bool isGlobal;

    private static int collectedCounter = 0;
    private const int threshold = 5;
    
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
            
            if (++collectedCounter >= threshold)
            {
                collectedCounter = 0;
                FindObjectOfType<SoundManager>().PlayOnPickup();
            }

            Destroy(gameObject);
        }
    }
}
