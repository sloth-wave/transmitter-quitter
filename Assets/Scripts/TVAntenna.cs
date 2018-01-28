﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVAntenna : MonoBehaviour {

    bool antennaInPosition = false;
    float maxPossAntennaPos, minPossAntennaPos;

    float antennaNeededAntennaPosition = 45; //degrees

    void Start() {
        antennaNeededAntennaPosition = Random.Range(minPossAntennaPos, maxPossAntennaPos);
    }

	// Update is called once per frame
	void Update () {

        if (DialControl.Position() > (antennaNeededAntennaPosition + 2) && DialControl.Position() < (antennaNeededAntennaPosition - 2)) {
            antennaInPosition = true;
        }
       
	}
}
