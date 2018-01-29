using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChannelManager : MonoBehaviour {

	private static int channelIndex;


	public static int GetChannelIndex()
	{
		return channelIndex;	
	}

	public static void DecreaseChannelCount()
	{
		channelIndex--;	
	}

	public static void IncreaseChannelCount()
	{
		channelIndex++;
	}
		
	public static void ChangeToNextChannel()
	{
		int sceneIndex = SceneManager.GetActiveScene ().buildIndex;

		if (sceneIndex+1 >= SceneManager.sceneCountInBuildSettings) {
			sceneIndex = 1;
			channelIndex = 1;
			SceneManager.LoadScene (sceneIndex);
			return;
		}

		sceneIndex += 1;
		SceneManager.LoadScene (sceneIndex);
	}

	public static void StartOver()
	{
		channelIndex = 0;
		SceneManager.LoadScene (0);
	}
}
