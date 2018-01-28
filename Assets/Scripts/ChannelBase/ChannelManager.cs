using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChannelManager : MonoBehaviour {

    //List<IChannel> channel = new List<IChannel>();
	public Scene currentChannel;
	public Scene nextChannel;

    public ChannelManager() 
	{
    }

	public void ChangeToNextChannel()
	{
		int sceneIndex = SceneManager.GetActiveScene ().buildIndex;
		sceneIndex++;

		SceneManager.LoadScene(sceneIndex);
	}

	public void ChangeToSceneByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}


}
