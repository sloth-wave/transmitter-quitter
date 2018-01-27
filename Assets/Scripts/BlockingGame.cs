using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingGame : MonoBehaviour {

    private GameObject screen;
    public float sensitivity;
    float position = 0;
    void Start() {
        screen = GameObject.FindGameObjectWithTag("Screen");
    }

	// Update is called once per frame
	void Update () {
        position = Mathf.Clamp(DialControl.Position(), -screen.transform.lossyScale.x / 2, screen.transform.lossyScale.x / 2);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(position, this.transform.position.y, this.transform.position.z), 6f * Time.deltaTime);
	}
}
