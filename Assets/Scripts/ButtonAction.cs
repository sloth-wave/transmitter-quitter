using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour {
		
	Button button;

	void Start(){
		button = GetComponent<Button> ();

		button.onClick.AddListener (StartGame);
	}

	void StartGame(){
		Debug.Log ("You made it here.\n");
		ChannelManager.ChangeToNextChannel ();
	}

}
