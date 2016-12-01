using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour
{
    public float magnitude;
    public bool destroyOnPickup;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            IMovement controller = (IMovement)other.GetComponent(typeof(BaseMovement));
            rb.AddForce(controller.CalculateMovement() * 10 * magnitude);
			//pms.speed = 20;
            if (destroyOnPickup)
            {
                Destroy(gameObject);
            }
        }
    }
}
