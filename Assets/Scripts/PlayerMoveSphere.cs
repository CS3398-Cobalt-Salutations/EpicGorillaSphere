using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMoveSphere : MonoBehaviour
{
	public float speed;
	public static int keyCount;
	public static int count;
	public Text countText;
	public Text winText;

    private IMovement controller;
	private Rigidbody rb;

	void Start ()
	{
        controller = (IMovement)GetComponent(typeof(BaseMovement));
		rb = GetComponent<Rigidbody>();
		count = 0;
		keyCount = 0;
		SetCountText ();
		winText.text = "";
	}
	void FixedUpdate ()
	{
        //float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");

        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        Vector3 movement = controller.CalculateMovement();

		rb.AddForce (movement * speed);
	}
    void Update()
    {
        if (count >= 5)
        {
            SceneManager.LoadScene("WinScreen", LoadSceneMode.Additive);
        }
    }
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Space Object"))  
		{
			other.gameObject.SetActive (false);
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddExplosionForce (10, movement, 10); 
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
