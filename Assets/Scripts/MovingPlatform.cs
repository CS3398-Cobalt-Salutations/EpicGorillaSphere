using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour 
{
	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	public bool Switch = false;
	private float pauseTime;
	public float delayBeforeMoving;
	private bool arrivedAtOurDestination = false;

	void FixedUpdate()
	{
		if ((transform.position == DestinationSpot.position) && !arrivedAtOurDestination)
		{
			Switch = true;
			pauseTime = Time.time + delayBeforeMoving;
			arrivedAtOurDestination = true;
		}

		if ((transform.position == OriginSpot.position) && !arrivedAtOurDestination)
		{
			Switch = false;
			pauseTime = Time.time + delayBeforeMoving;
			arrivedAtOurDestination = true;
		}


		if (Switch && (Time.time > pauseTime))
		{
			transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position, Speed);
			arrivedAtOurDestination = false;
		}

		else if (Time.time > pauseTime)
		{
			transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed);
			arrivedAtOurDestination = false;
		}
	}
}﻿
