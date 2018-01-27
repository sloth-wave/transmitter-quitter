using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class TestScript: MonoBehaviour 
{
	void Start()
	{
		string text = JsonHelper.LoadResourcesAsTextfile("channeldata.json");

		ChannelData cd = JsonUtility.FromJson<ChannelData> (text);

		Debug.Log (cd.channels+"\n");
	}
}

[Serializable]
public class ChannelData
{
	public Channel[] channels;
}