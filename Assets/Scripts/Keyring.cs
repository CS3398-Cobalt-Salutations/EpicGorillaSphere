using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Keyring : MonoBehaviour
{
    public int maxCapacity;
    public Text keyText;

    private List<Key> personalKeys;
    private static List<Key> globalKeys = new List<Key>();

    void Start()
    {
        personalKeys = new List<Key>();
        UpdateKeyDisplay();
    }

    public bool AddKey(Key key)
    {
        if (IsLimited && CombinedKeyCount >= maxCapacity) return false;

        if (key.isGlobal)
        {
            globalKeys.Add(key);
            Keyring[] keyHolders = Object.FindObjectsOfType<Keyring>();
            foreach (Keyring holder in keyHolders)
            {
                holder.UpdateKeyDisplay();
            }
        }
        else
        {
            personalKeys.Add(key);
            UpdateKeyDisplay();
        }
        return true;
    }

    public static Key GetGlobalKey(int index)
    {
        return globalKeys[index];
    }

    public static void RemoveGlobalKey(int index)
    {
        globalKeys.RemoveAt(index);
        Keyring[] keyHolders = Object.FindObjectsOfType<Keyring>();
        foreach (Keyring holder in keyHolders)
        {
            holder.UpdateKeyDisplay();
        }
    }

    public void RemovePersonalKey(int index)
    {
        personalKeys.RemoveAt(index);
        UpdateKeyDisplay();
    }

    public Key GetPersonalKey(int index)
    {
        return personalKeys[index];
    }

    private void UpdateKeyDisplay()
    {
        if (keyText == null) return;
        keyText.text = "Keys: " + CombinedKeyCount.ToString();
    }

    public int PersonalKeyCount { get { return personalKeys.Count; } }
    public static int GlobalKeyCount { get { return globalKeys.Count; } }
    public int CombinedKeyCount { get { return PersonalKeyCount + GlobalKeyCount; } }
    public bool IsLimited { get { return maxCapacity >= 0; } }
}
