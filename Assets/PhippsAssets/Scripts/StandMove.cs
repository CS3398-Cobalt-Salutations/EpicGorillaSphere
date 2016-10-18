using UnityEngine;
using System.Collections;

public class StandMove : MonoBehaviour {

    public float speed = 5;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 moveHoriz = rb.velocity;
        moveHoriz.x = (Input.GetAxisRaw("Horizontal") *5);
        rb.velocity = moveHoriz;

        if(Input.GetKeyUp("space"))
        {
            DestroyObject(gameObject);
        }



       // Vector3 movement = new Vector3(moveHoriz, 0,0);
        //rb.AddForce(movement * speed);

    }
}
