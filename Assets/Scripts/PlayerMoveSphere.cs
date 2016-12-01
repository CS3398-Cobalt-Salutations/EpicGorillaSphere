using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(ScoreKeeper))]
[RequireComponent(typeof(Keyring))]
[RequireComponent(typeof(LifeManager))]
public class PlayerMoveSphere : MonoBehaviour
{
	public float speed;
    public int playerNumber;

    private IMovement controller;
	private Rigidbody rb;

	void Start ()
	{
        controller = (IMovement)GetComponent(typeof(BaseMovement));
		rb = GetComponent<Rigidbody>();
        SaveAndLoad.Initialize();
        SaveAndLoad.SetInitialState(this);
        SavePosition();
	}

	void FixedUpdate ()
	{
        Vector3 movement = controller.CalculateMovement();
		rb.AddForce (movement * speed);
	}
    
    public void SavePosition()
    {
        SaveAndLoad.SaveState(this);
    }

    public void LoadPosition()
    {
        SaveAndLoad.LoadState(this);
    }
}
