using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{
    public int id;
    public bool isGlobal;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        Keyring keyring = other.GetComponent<Keyring>();
        if (keyring != null)
        {
            if (keyring.AddKey(this))
            {
                Destroy(gameObject);
            }
        }
    }
}
