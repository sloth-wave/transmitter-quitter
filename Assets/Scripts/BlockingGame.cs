using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingGame : MonoBehaviour {
    
    public float sensitivity;
    public float min, max;
    public float position;

    void Start() {
    }

	// Update is called once per frame
	void Update () {
        position = DialControl.ClampedPosition(position, min, max);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(position, this.transform.position.y, this.transform.position.z), 6f * Time.deltaTime);
	}
}
