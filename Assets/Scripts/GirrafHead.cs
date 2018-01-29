using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirrafHead : MonoBehaviour {

  	public DestroyOnTouch apples;
  	public Text winText;
	public Text counterText;
  	public Text timerText;

	void Start()
	{
		winText.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
    checkapples(); 
  }

  private void checkapples() {

    counterText.text = apples.killCount + " / 12";

    if(apples.killCount == 12){
      // @TODO: Tell the channel manager we won: ChannelManager.getCurrentChannel()
			Win();
    }
			
  }

	private void Win(){

		// Show win text
		winText.gameObject.SetActive(true);
		Debug.Log("You win\n");

		winText.gameObject.SetActive (true);

		// Call change channel in ChannelManager
		StartCoroutine (ChangeChannel());
	}

	public IEnumerator ChangeChannel()
	{
		yield return new WaitForSeconds (1);
		ChannelManager.ChangeToNextChannel();
	}


}
