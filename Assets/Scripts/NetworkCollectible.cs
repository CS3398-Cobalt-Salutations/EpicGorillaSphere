using UnityEngine;
using System.Collections;

public class NetworkCollectible : MonoBehaviour
{
    public int pointValue;
    public bool isGlobal;

    void OnTriggerEnter(Collider other)
    {
        GameObject otherObj = other.gameObject;
        ControlPlayer player = otherObj.GetComponent<ControlPlayer>();
        if (player != null)
        {
            if (isGlobal)
            {
                GameManager.Collect(this);
            }
            else
            {
                player.UpdateScore(pointValue);
                Destroy(gameObject);
            }
        }
    }
}
