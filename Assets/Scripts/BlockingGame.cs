using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingGame : MonoBehaviour {
    
    public float sensitivity;
    public float min, max;
    public float position;

    public Camera cam;

    float height;
    float width;

    void Start() {
        height = 2* cam.orthographicSize;
        width = height* Camera.main.aspect;
    }

	// Update is called once per frame
	void Update () {
        position = DialControl.ClampedPosition(position, -width / 2, width / 2);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(position, this.transform.position.y, this.transform.position.z), 6f * Time.deltaTime);
	}
}
