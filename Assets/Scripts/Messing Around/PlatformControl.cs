using UnityEngine;
using System.Collections;

public class PlatformControl : MonoBehaviour {


    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //moves platform in MonkeyBallTest Scene
    //Fixed Update is supposedly called when Physics happen. 
    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(moveHoriz, 0.0f, moveVertical));

       


    }
}