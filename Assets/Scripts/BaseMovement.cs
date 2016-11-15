using UnityEngine;
using System.Collections;

public class BaseMovement : MonoBehaviour, IMovement
{
    protected Vector3 relativeRight = Vector3.right;
    protected Vector3 relativeForward = Vector3.forward;

    virtual public Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        movement = relativeRight * Input.GetAxis("Horizontal") + relativeForward * Input.GetAxis("Vertical");
        //movement.x = Input.GetAxis("Horizontal");
        //movement.z = Input.GetAxis("Vertical");

        return movement;
    }

    virtual public Vector2 CalculateRotation()
    {
        Vector2 rotation = new Vector2();

        rotation.x = Input.GetAxis("Horizontal");
        rotation.y = Input.GetAxis("Vertical");

        return rotation;
    }

    public void SetForwardRelative(Vector3 up, Vector3 right, Vector3 forward)
    {
        relativeRight = Vector3.Cross(up, forward);
        relativeForward = Vector3.Cross(right, up);
    }
}
