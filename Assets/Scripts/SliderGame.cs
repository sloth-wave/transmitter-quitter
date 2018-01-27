using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderGame : MonoBehaviour {

    private GameObject screen;
    public float sensitivity;
    float position = 0;
    void Start() {
        screen = GameObject.FindGameObjectWithTag("Screen");
    }

	// Update is called once per frame
	void Update () {
        position = Mathf.Clamp(DialControl.Position(), -screen.transform.lossyScale.x / 2, screen.transform.lossyScale.x / 2);
        this.transform.position = new Vector3(position, 0, 0);
	}
}
