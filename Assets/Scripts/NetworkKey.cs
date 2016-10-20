using UnityEngine;
using System.Collections;

public class NetworkKey : MonoBehaviour
{
    public int pickupAmount;
    public bool isGlobal;

    void OnTriggerEnter(Collider other)
    {
        GameObject otherObj = other.gameObject;
        ControlPlayer player = otherObj.GetComponent<ControlPlayer>();
        if (player != null)
        {
            if (isGlobal)
            {
                GameManager.PickupKey(this);
            }
            else
            {
                player.UpdateKeyCount(pickupAmount);
                Destroy(gameObject);
            }
        }
    }
}
