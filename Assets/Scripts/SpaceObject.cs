using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class SpaceObject : MonoBehaviour
{
    public float speed;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            IMovement controller = (IMovement)other.GetComponent(typeof(BaseMovement));
            rb.AddForce(controller.CalculateMovement() * speed);
        }
    }
}
