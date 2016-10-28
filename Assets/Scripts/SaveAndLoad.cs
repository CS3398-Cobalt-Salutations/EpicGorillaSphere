using UnityEngine;
using System.Collections;

public static class SaveAndLoad {

	public static void SaveState(Vector3 state)
	{
		PlayerPrefs.SetFloat ("PosX", state.x);
		PlayerPrefs.SetFloat ("PosY", state.y);
		PlayerPrefs.SetFloat ("PosZ", state.z);
	}

	public static Vector3 LoadState()
	{
        float x = PlayerPrefs.GetFloat ("PosX");
		float y = PlayerPrefs.GetFloat ("PosY");
		float z = PlayerPrefs.GetFloat ("PosZ");

		return new Vector3 (x, y, z);
	}

}
