using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGame : MonoBehaviour {

    public float sensitivity = 5;

	// Update is called once per frame
	void Update () {

        Quaternion rotation = this.transform.rotation;
        float position = DialControl.Position() * sensitivity;
        rotation.eulerAngles = new Vector3(rotation.eulerAngles.x, rotation.eulerAngles.y, position);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotation, 6f * Time.deltaTime);
	}
}
