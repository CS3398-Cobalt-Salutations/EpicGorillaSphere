using UnityEngine;
using System.Collections;

public class CollectibleRotator : MonoBehaviour {

	public float rotateX;
	public float rotateY;
	public float rotateZ;
	void Update () 
	{
		transform.Rotate (new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime);
	}
}
