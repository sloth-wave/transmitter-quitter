using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGame : MonoBehaviour {

    public float velocity = 0;

	void Update () {
        velocity = DialControl.Velocity();
	}
}
