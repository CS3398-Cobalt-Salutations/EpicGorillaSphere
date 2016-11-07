﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMoveSphere : MonoBehaviour {

	public float speed;
	public static int keyCount;
	public static int count;
	public Text countText;
	public Text winText;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		keyCount = 0;
		SetCountText ();
		winText.text = "";
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Collectible")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			if (count >= 5) 
			{
				SceneManager.LoadScene ("WinScreen", LoadSceneMode.Additive);
			}

		}
		if (other.gameObject.CompareTag ("Space Object"))  
		{
			other.gameObject.SetActive (false);
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddExplosionForce (10, movement, 10); 
		}
		if (other.gameObject.CompareTag ("Speed Boost"))
		{
			other.gameObject.SetActive (false);
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddForce (movement * speed * 20);
		}
    }
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 5)
		{
			winText.text = "You Win!";
		}
	}
}
