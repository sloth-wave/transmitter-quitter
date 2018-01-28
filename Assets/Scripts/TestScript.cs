using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class TestScript: MonoBehaviour 
{

	List<Channel> channels = new List<Channel>();


	void Start()
	{
//		string text = JsonHelper.LoadResourcesAsTextfile("channeldata.json");
//
//		ChannelData cd = JsonUtility.FromJson<ChannelData> (text);
//
//		foreach (Channel c in cd.channels)
//		{
//			channels.Add (c);
//		}
//
//		Debug.Log ("Loaded channels\n");
//
//		SaveChannel ();
	}

	void SaveChannel()
	{
//		Channel c = new Channel ();
//		c.channelname = "Test Channel";
//		c.channelType = "SpeedGame";
//		c.spriteArray = new string[]{"sprite_01", "sprite_2", "srpite_03"};
//
//		channels.Add (c);
//
//		ChannelData cd = new ChannelData ();
//		cd.channels = channels.ToArray ();
//
//		string json = JsonUtility.ToJson (cd);
//
//		Debug.Log (json+"\n");
//
//		FileStream file = File.Create ("Resources/channels.json", );

	}


}

[Serializable]
public class ChannelData
{
	public Channel[] channels;
}