using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            pms.LoadPosition();
        }
    }
}
