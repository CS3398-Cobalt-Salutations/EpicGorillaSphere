using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "PlayerSphere")
		{
			PlayerMoveSphere.keyCount = PlayerMoveSphere.keyCount + 1;
			Destroy (gameObject);
		}
    }
}
