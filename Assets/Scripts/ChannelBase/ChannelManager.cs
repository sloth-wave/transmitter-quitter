using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChannelManager : MonoBehaviour {


	public static void ChangeToNextChannel()
	{
		int sceneIndex = SceneManager.GetActiveScene ().buildIndex;
		sceneIndex++;

		SceneManager.LoadScene(sceneIndex);
	}

	public static void ChangeToSceneByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}


}
