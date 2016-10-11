using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public static class SaveLoad {

	//Creates a list of saved games
	public static List<Game> savedGames = new List<Game>();

	//Static allows calls from anywhere
	public static void Save() {
    		savedGames.Add(Game.current);

   		 //Handles serialization
    		BinaryFormatter bf = new BinaryFormatter();

    		//Create gamedata file using Unity default location
    		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
    
    		//Save and close file
    		bf.Serialize(file, SaveLoad.savedGames);
    		file.Close();    
	}

	public static void Load() {
	    	if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
			BinaryFormatter bf = new BinaryFormatter();

			//Open the savedGames file
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
		
			//Deserialize and convert data to usable list
			SaveLoad.savedGames = (List<Game>)bf.Deserialize(file);
			file.Close();
	    	}
	}
}
