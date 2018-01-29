using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolphin : MonoBehaviour {


    public int currBeard = -1, lastBeard = -1;
    public GameObject[] beards;
    public GameObject win;

    float time = 5;
    public float timer = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currBeard > beards.Length) {
            win.SetActive(true);
            ChannelManager.ChangeToNextChannel();
        }

        if (time < 0) {
             
            if (lastBeard == currBeard)
            {
                currBeard++;
            }

            if ((lastBeard != currBeard))
            {
                beards[currBeard].SetActive(true);
                lastBeard = currBeard;
            }

        }



        time -= Time.deltaTime;

        
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision!!");
        timer = time;
        
    }

}
