﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{

	float totalTime = 60f;
	public Text timeText;

	public void Update()
	{
		totalTime -= Time.deltaTime;
		UpdateLevelTimer (totalTime);
	}

	void UpdateLevelTimer(float totalSeconds)
	{
		int seconds = Mathf.FloorToInt (totalSeconds % 60f);

		timeText.text = seconds.ToString ("00");
	}
} 
