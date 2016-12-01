using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem events;
    public GameObject selected;

    private bool buttonSelected;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetAxisRaw("Vertical") !=0 && buttonSelected == false)
        {

            events.SetSelectedGameObject(selected);
            buttonSelected = true;
        }


	}

    private void OnDisable()
    {
        //when the game object has been deactivated (you've moved to a different menu)
        buttonSelected = false;

    }
}
