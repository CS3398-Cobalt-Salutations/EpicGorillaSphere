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

        return movement;
    }

    private bool IsRightArrowPressed { get { return Input.GetKey(KeyCode.RightArrow); } }
    private bool IsLeftArrowPressed { get { return Input.GetKey(KeyCode.LeftArrow); } }
    private bool IsUpArrowPressed { get { return Input.GetKey(KeyCode.UpArrow); } }
    private bool IsDownArrowPressed { get { return Input.GetKey(KeyCode.DownArrow); } }
}
