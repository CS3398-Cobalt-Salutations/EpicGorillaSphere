using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "PlayerSphere" && PlayerMoveSphere.keyCount > 0)
		{
			PlayerMoveSphere.keyCount = PlayerMoveSphere.keyCount - 1;
			Destroy (gameObject);
		}
	}
}
