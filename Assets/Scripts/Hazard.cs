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
            LifeManager lm = other.GetComponent<LifeManager>();
            --lm.Lives;
            pms.LoadPosition();
        }
    }
}
