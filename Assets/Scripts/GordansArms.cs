using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GordansArms : MonoBehaviour {
    public DestroyOnTouch[] arms;
    public Text winText;
    public Text counterText;

    public int neededFruits = 100;

    // Update is called once per frame
    void Update () {

        int killCount = 0;
        for (int i = 0; i < arms.Length; i++) {
            arms[i].killCount += killCount;
        }

        counterText.text = killCount + " / " + neededFruits;

        if (killCount > neededFruits) {
            winText.enabled = true;
        }
	}
}
