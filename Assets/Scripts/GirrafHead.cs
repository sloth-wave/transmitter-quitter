using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirrafHead : MonoBehaviour {

  public DestroyOnTouch apples;
  public Text counterText;

	// Update is called once per frame
	void Update () {
    checkapples();
  }

  private void checkapples() { 

    counterText.text = apples.killCount + " / 12";

    if(apples.killCount == 12){
      // @TODO: Tell the channel manager we won: ChannelManager.getCurrentChannel()
    }
  }

}
