using UnityEngine;
using System.Collections;

public class CustomMovement : MonoBehaviour
{
    public string xAxis;
    public string zAxis;

    public Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        movement.x = Input.GetAxis(xAxis);
        movement.z = Input.GetAxis(zAxis);

        return movement;
    }
}
