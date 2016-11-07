using UnityEngine;
using System.Collections;

public class CollisionTests : MonoBehaviour {
    
    private BoxCollider bc;
    
    
    

	// Use this for initialization
	void Start () {
        bc = GetComponent<BoxCollider>();
	}

    void OnCollisionEnter(Collision coll){
        ContactPoint contact = coll.contacts[0]; // what does this say / mean. 
        Vector3 pos = contact.point;
        Destroy(gameObject);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
