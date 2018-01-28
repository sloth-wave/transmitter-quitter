using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGame : MonoBehaviour {

    public float sensitivity = 5;
    public float speed = 6f;

    public float offsetPos = 0;
    public float position = 0;

    [Space]
    public bool  limitRotation  = false;
    public float maxRotation    = 0;
    public float minRotation    = 0;

	   // Update is called once per frame
     void Update () {
        Rotate(limitRotation);
	 }

     void Rotate (bool limitRotation){
        if (!limitRotation) {
            position = DialControl.Position() * sensitivity;
        } else {
            position = DialControl.ClampedPosition(position * sensitivity, minRotation, maxRotation);
        }

        

        Quaternion rotation = this.transform.rotation;
        rotation.eulerAngles = new Vector3(rotation.eulerAngles.x, rotation.eulerAngles.y, position + offsetPos);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotation, speed * Time.deltaTime);
    }
}
