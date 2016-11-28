﻿using UnityEngine;
using System.Collections;

public class RiMPost : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    private bool dirRight = true;
    public float speed = 2.0f;


    void Update()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x >= (12.0f))
        {
            dirRight = false;
        }

        if (transform.position.x <= (4))
        {
            dirRight = true;
        }
    }
}
