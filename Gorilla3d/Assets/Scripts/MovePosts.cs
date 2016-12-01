using UnityEngine;
using System.Collections;

public class MovePosts : MonoBehaviour
{


    void Start()
    {
        //var startPos = Transform.position;
    }

    // Update is called once per frame
    /* void Update () {
        while(transform.position.x < 5)
        {

            transform.Translate(Vector3.right * Time.deltaTime,Space.World);
        }
         //(transform.position.x >= 5) 
        {

            transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }
        Debug.Log(transform.position.x);
        */
    //	}
    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
    }
}
