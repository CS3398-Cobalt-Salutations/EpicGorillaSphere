using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerMoveSphere player;
    public float rotationSpeed;
	private Vector3 offset;
    private IMovement controller;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
        controller = (IMovement)player.GetComponent(typeof(BaseMovement));
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
        Vector2 rotation = controller.CalculateRotation();

        offset = Quaternion.AngleAxis(rotation.x * rotationSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(rotation.y * rotationSpeed, Vector3.right) * offset;

		transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);

        controller.SetForwardRelative(transform.up, transform.right, transform.forward);
	}
}
