﻿using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{
    public int value;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            PlayerMoveSphere.keyCount += value;
            Destroy(gameObject);
        }
    }
}
