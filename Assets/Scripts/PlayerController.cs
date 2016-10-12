using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
	private Vector3 checkpoint;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Checkpoint") 
		{
			checkpoint = transform.position;
		}
			
		else if(other.gameObject.tag == "Hazard") 
		{
			transform.position = checkpoint;
		}

		else if (other.gameObject.tag == "Fallout") 
		{
			transform.position = checkpoint;
		} 
	}
}
