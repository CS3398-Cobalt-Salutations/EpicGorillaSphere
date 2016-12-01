using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public int[] matchIds;
	public GameObject door;
	public Animator doorOpen;
	public Animator doorClose;

	//Use for initialization
	void Start () {
		door = gameObject;
		doorOpen = door.GetComponent<Animator>();
		doorClose = door.GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        Keyring keyring = other.GetComponent<Keyring>();
        if (keyring != null)
        {
            if (Unlock(ref keyring))
            {
				doorOpen.SetTrigger("Open");
            }
        }
    }

    public bool Unlock(ref Keyring keyring)
    {
        bool isOpen = false;

        for (int i = 0; i < matchIds.Length; ++i)
        {
            bool foundMatch = false;
            // Search through personal keys
            for (int k = 0; k < keyring.PersonalKeyCount; ++k)
            {
                if (matchIds[i] == keyring.GetPersonalKey(k).id)
                {
                    RemoveFromArray(i);
                    keyring.RemovePersonalKey(k);
                    foundMatch = true;
                    break;
                }
            }
            if (foundMatch && matchIds.Length == 0)
            {
                isOpen = true;
                break;
            }
            // Search through global keys
            for (int k = 0; k < Keyring.GlobalKeyCount; ++k)
            {
                if (matchIds[i] == Keyring.GetGlobalKey(k).id)
                {
                    RemoveFromArray(i);
                    Keyring.RemoveGlobalKey(k);
                    foundMatch = true;
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
        if (index < 0 || index >= matchIds.Length) return;

        int[] newMatchIds = new int[matchIds.Length - 1];
        for (int i = 0; i < index; ++i)
        {
            newMatchIds[i] = matchIds[i];
        }
        for (int i = index; i < matchIds.Length - 1; ++i)
        {
            matchIds[i] = matchIds[i + 1];
        }

        matchIds = newMatchIds;
    }
}
