using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGame : MonoBehaviour {

    public float velocity = 0;

    List<float> values = new List<float>();
    public float average = 0;
    int started = 0;

	void Update () {
        velocity = DialControl.Velocity();

        if (started == 0 && velocity != 0) {
            started = 1;
        }

        if (started == 1) {
            if (velocity != 0){
                values.Add(velocity);
            } else {
                started = 2;
                for (int i = 0; i < values.Count; i++) {
                    average += values[i];
                }
                average /= values.Count;
            }
        }

        if (started == 2) {
            //TODO :: Do something
        }
	}
}
