using UnityEngine;
using System.Collections;

public class LeMPost : MonoBehaviour {
    //Truly Top and Bottom Left Posts.

    // Use this for initialization
    void Start()
    {
        Vector3 starPos = transform.position;
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

        if (transform.position.x >= (-4.0f))
        {
            dirRight = false;
        }

        if (transform.position.x <= (-12))
        {
            dirRight = true;
        }
    }
}