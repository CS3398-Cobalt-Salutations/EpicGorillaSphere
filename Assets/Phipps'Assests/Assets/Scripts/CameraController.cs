using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Gurrila;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - Gurrila.transform.position;
	}
	
	// LateUpdate is called once per frame but only after everything else that would update usually in update. 
	void LateUpdate () {
        transform.position = Gurrila.transform.position + offset;
	}
}
