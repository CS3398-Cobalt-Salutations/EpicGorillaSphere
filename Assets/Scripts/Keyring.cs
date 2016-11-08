using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Keyring : MonoBehaviour
{
    public int maxCapacity;

    private List<Key> personalKeys;
    private static List<Key> globalKeys = new List<Key>();

    void Start()
    {
        personalKeys = new List<Key>();
    }

    public bool AddKey(Key key)
    {
        if (IsLimited && CombinedKeyCount >= maxCapacity) return false;

        if (key.isGlobal)
        {
            globalKeys.Add(key);
        }
        else
        {
            personalKeys.Add(key);
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
    }

    public void RemovePersonalKey(int index)
    {
        personalKeys.RemoveAt(index);
    }

    public Key GetPersonalKey(int index)
    {
        return personalKeys[index];
    }

    public int PersonalKeyCount { get { return personalKeys.Count; } }
    public static int GlobalKeyCount { get { return globalKeys.Count; } }
    public int CombinedKeyCount { get { return PersonalKeyCount + GlobalKeyCount; } }
    public bool IsLimited { get { return maxCapacity >= 0; } }
}
