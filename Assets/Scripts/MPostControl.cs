using UnityEngine;
using System.Collections;

public class MPostControl : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
     Vector3 starPos = transform.position;
    }

    // Update is called once per frame
    private bool dirRight = true;
    public float speed = 3.0f;

  
    void Update()
    {
       
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= (  5.0f))
        {
            dirRight = false;
        }

        if (transform.position.x <= (-5))
        {
            dirRight = true;
        }
    }
}