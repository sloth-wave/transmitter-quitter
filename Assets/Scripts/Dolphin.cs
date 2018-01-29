using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolphin : MonoBehaviour {


    public int currBeard = -1, lastBeard = -1;
    public GameObject[] beards;
    public GameObject win;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currBeard > beards.Length) {
            win.SetActive(true);

            ChannelManager.ChangeToNextChannel();
        }

        if (lastBeard != currBeard) {
            beards[currBeard].SetActive(true);
            lastBeard = currBeard;
        }


	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision!!");
        currBeard++;
    }
}
