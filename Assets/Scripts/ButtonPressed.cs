using UnityEngine;
using System.Collections;

public class ButtonPressed : MonoBehaviour {
    public GameObject player;
    public GameObject door;
    public Animator doorOpen;
   
    public Animator doorClose;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        door = GameObject.Find("Door");
        doorOpen = door.GetComponent<Animator>();
        doorClose = door.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

   
    void OnTriggerEnter(Collider playerCollider)
    {
        if (playerCollider.gameObject.tag == "Player")
        {
            doorOpen.SetTrigger("ButtonDown");
            
        }
    }

    void OnTriggerExit(Collider playerCollider)
    {
        if(playerCollider.gameObject.tag == "Player")
        {
            doorClose.SetTrigger("ButtonUp");
        }

    }
}
