using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public static class JsonHelper {

	// Load json data as text
	public static string LoadResourcesAsTextfile(string filepath)
	{
		// Remove the extension for Resource method
		string path = filepath.Replace(".json","");

		TextAsset file = Resources.Load<TextAsset>(path);

		return file.text;
	}

	// Save channel to json
	public static void SaveResourcesAsJsonFile(Channel channel)
	{
		string json = JsonUtility.ToJson(channel);

		Debug.Log (json+"\n");
	}
}
