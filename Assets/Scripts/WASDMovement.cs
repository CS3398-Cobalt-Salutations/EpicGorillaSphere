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

        return movement;
    }

    private bool IsDPressed { get { return Input.GetKey(KeyCode.D); } }
    private bool IsAPressed { get { return Input.GetKey(KeyCode.A); } }
    private bool IsWPressed { get { return Input.GetKey(KeyCode.W); } }
    private bool IsSPressed { get { return Input.GetKey(KeyCode.S); } }
}
