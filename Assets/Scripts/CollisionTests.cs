using UnityEngine;
using System.Collections;

public class CollisionTests : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    void OnCollisionEnter(Collision coll){
        Destroy(gameObject);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
