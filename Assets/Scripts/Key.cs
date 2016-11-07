﻿using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            PlayerMoveSphere.keyCount += 1;
            Destroy(gameObject);
        }
    }
}
