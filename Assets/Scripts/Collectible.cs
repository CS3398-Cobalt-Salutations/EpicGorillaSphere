using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{
    public int value;
    
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            PlayerMoveSphere.count += value;
            pms.UpdateCountText();
            Destroy(gameObject);
        }
    }
}
