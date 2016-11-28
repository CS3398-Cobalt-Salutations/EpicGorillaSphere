using UnityEngine;
using System.Collections;

public class WASDMovement : BaseMovement
{
    override public Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        if (IsDPressed)
        {
            movement.x = 1.0f;
        }
        else if (IsAPressed)
        {
            movement.x = -1.0f;
        }

        if (IsWPressed)
        {
            movement.z = 1.0f;
        }
        else if (IsSPressed)
        {
            movement.z = -1.0f;
        }

        movement = relativeRight * movement.x + relativeForward * movement.z;

        return movement;
    }

    override public Vector2 CalculateRotation()
    {
        Vector2 rotation = new Vector2();

        if (IsKPressed)
        {
            rotation.y = -1.0f;
        }
        else if (IsIPressed)
        {
            rotation.y = 1.0f;
        }

        if (IsJPressed)
        {
            rotation.x = -1.0f;
        }
        else if (IsLPressed)
        {
            rotation.x = 1.0f;
        }

        return rotation;
    }

    private bool IsJPressed { get { return Input.GetKey(KeyCode.J); } }
    private bool IsLPressed { get { return Input.GetKey(KeyCode.L); } }
    private bool IsIPressed { get { return Input.GetKey(KeyCode.I); } }
    private bool IsKPressed { get { return Input.GetKey(KeyCode.K); } }
    private bool IsDPressed { get { return Input.GetKey(KeyCode.D); } }
    private bool IsAPressed { get { return Input.GetKey(KeyCode.A); } }
    private bool IsWPressed { get { return Input.GetKey(KeyCode.W); } }
    private bool IsSPressed { get { return Input.GetKey(KeyCode.S); } }
}
