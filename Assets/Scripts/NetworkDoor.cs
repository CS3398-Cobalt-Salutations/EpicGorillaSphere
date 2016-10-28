using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkDoor : NetworkBehaviour
{
    public int keysRequired;
    public bool isGlobal;

    void OnTriggerEnter(Collider other)
    {
        GameObject otherObj = other.gameObject;
        ControlPlayer player = otherObj.GetComponent<ControlPlayer>();
        if (player != null && player.keyCount >= keysRequired)
        {
            if (isGlobal)
            {
                GameManager.OpenDoor(this);
            }
            else
            {
                player.UpdateKeyCount(-keysRequired);
                Destroy(gameObject);
            }
        }
    }
}
