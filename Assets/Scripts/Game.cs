using UnityEngine;
using System.Collections;

//Allows Unity to save variables listed in this script
[System.Serializable]
public class Game {


	public static Game current;	//Static reference to the current instance
	public Character Player;

	public Game () {
		Player = new Character();
	}
}
