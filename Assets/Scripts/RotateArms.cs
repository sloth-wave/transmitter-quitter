using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArms : MonoBehaviour {

    public float scroll;
    public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scroll = Input.GetAxis("Dial");

        transform.Rotate(0, 0, scroll * speed);
	}
}
