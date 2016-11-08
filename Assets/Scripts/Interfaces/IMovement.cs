using UnityEngine;
using System.Collections;

public interface IMovement
{
    Vector3 CalculateMovement();
    Vector2 CalculateRotation();
    void SetForwardRelative(Vector3 up, Vector3 right, Vector3 forward);
}
