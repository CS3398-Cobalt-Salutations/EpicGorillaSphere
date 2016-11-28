using UnityEngine;
using System.Collections;

public class ArrowKeyMovement : BaseMovement
{
    override public Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        if (IsRightArrowPressed)
        {
            movement.x = 1.0f;
        }
        else if (IsLeftArrowPressed)
        {
            movement.x = -1.0f;
        }

        if (IsUpArrowPressed)
        {
            movement.z = 1.0f;
        }
        else if (IsDownArrowPressed)
        {
            movement.z = -1.0f;
        }

        movement = relativeRight * movement.x + relativeForward * movement.z;

        return movement;
    }

    override public Vector2 CalculateRotation()
    {
        Vector2 rotation = new Vector2();

        if (IsKeypad2Pressed)
        {
            rotation.y = -1.0f;
        }
        else if (IsKeypad8Pressed)
        {
            rotation.y = 1.0f;
        }

        if (IsKeypad4Pressed)
        {
            rotation.x = -1.0f;
        }
        else if (IsKeypad6Pressed)
        {
            rotation.x = 1.0f;
        }

        return rotation;
    }

    private bool IsKeypad4Pressed { get { return Input.GetKey(KeyCode.Keypad4); } }
    private bool IsKeypad6Pressed { get { return Input.GetKey(KeyCode.Keypad6); } }
    private bool IsKeypad8Pressed { get { return Input.GetKey(KeyCode.Keypad8); } }
    private bool IsKeypad2Pressed { get { return Input.GetKey(KeyCode.Keypad2); } }
    private bool IsRightArrowPressed { get { return Input.GetKey(KeyCode.RightArrow); } }
    private bool IsLeftArrowPressed { get { return Input.GetKey(KeyCode.LeftArrow); } }
    private bool IsUpArrowPressed { get { return Input.GetKey(KeyCode.UpArrow); } }
    private bool IsDownArrowPressed { get { return Input.GetKey(KeyCode.DownArrow); } }
}
