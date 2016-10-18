using UnityEngine;
using System.Collections;

public class SaveAndLoad : MonoBehaviour {

	public void SaveState()
	{
		PlayerPrefs.SetFloat ("PosX", transform.position.x);
		PlayerPrefs.SetFloat ("PosY", transform.position.y);
		PlayerPrefs.SetFloat ("PosZ", transform.position.z);
	}

	public void LoadState()
	{
		float x = PlayerPrefs.GetFloat ("PosX");
		float y = PlayerPrefs.GetFloat ("PosY");
		float z = PlayerPrefs.GetFloat ("PosZ");

		transform.position = new Vector3 (x, y, z);
	}

}
