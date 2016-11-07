using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public int[] matchIds;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        Keyring keyring = other.GetComponent<Keyring>();
        if (keyring != null)
        {
            if (Unlock(ref keyring))
            {
                Destroy(gameObject);
            }
        }
    }

    // TODO: Fix this
    public bool Unlock(ref Keyring keyring)
    {
        bool isOpen = false;

        for (int i = 0; i < matchIds.Length; ++i)
        {
            bool foundMatch = false;
            for (int k = 0; k < keyring.PersonalKeyCount; ++k)
            {
                if (matchIds[i] == keyring.GetPersonalKey(k).id)
                {
                    RemoveFromArray(i);
                    keyring.RemovePersonalKey(k);
                    break;
                }
            }
            if (foundMatch && matchIds.Length == 0)
            {
                isOpen = true;
                break;
            }
            for (int k = 0; k < Keyring.GlobalKeyCount; ++k)
            {
                if (matchIds[i] == Keyring.GetGlobalKey(k).id)
                {
                    RemoveFromArray(i);
                    Keyring.RemoveGlobalKey(k);
                    break;
                }
            }
            if (foundMatch && matchIds.Length == 0)
            {
                isOpen = true;
                break;
            }
        }

        return isOpen;
    }

    private void RemoveFromArray(int index)
    {
        for (int i = index; i < matchIds.Length - 1; ++i)
        {
            matchIds[i] = matchIds[i + 1];
        }
    }
}
