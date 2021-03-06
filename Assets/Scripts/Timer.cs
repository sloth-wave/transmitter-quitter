﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{

	public float totalTime = 5f;
	public Text timeText;
    public bool disable = false;

	public void Update()
	{
        if (disable)
        {
            return;
        }

		totalTime -= Time.deltaTime;
		UpdateLevelTimer (totalTime);
	}

	void UpdateLevelTimer(float totalSeconds)
	{
		if(totalSeconds<0)
		{
			timeText.text = "Times up, fool!";
			StartCoroutine (ChannelChange());
			return;
		}
		int minutes = Mathf.FloorToInt (totalSeconds / 60f);
		int seconds = Mathf.RoundToInt (totalSeconds % 60f);

		if (seconds == 60) 
		{
			minutes += 1;
			seconds = 0;
		}

		timeText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
	}

	public IEnumerator ChannelChange()
	{
		yield return new WaitForSeconds (1);
		ChannelManager.ChangeToNextChannel ();
	}
		
} 
