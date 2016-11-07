using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public int keysRequired;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null && PlayerMoveSphere.keyCount >= keysRequired)
        {
            PlayerMoveSphere.keyCount -= keysRequired;
            Destroy(gameObject);
        }
    }
}
