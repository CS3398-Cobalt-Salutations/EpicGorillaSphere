using UnityEngine;
using System.Collections;

public class BaseMovement : MonoBehaviour, IMovement
{
    virtual public Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();

        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        return movement;
    }
}
