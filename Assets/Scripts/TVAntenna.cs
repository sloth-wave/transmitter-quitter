using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVAntenna : MonoBehaviour {

    bool antennaInPosition = false;
    float maxPossAntennaPos, minPossAntennaPos;
    float sensitivity = 1f;

    bool clampPosition = false; 

    float antennaNeededAntennaPosition = 45; //degrees

    float position = 0;

    void Start() {
        antennaNeededAntennaPosition = Random.Range(minPossAntennaPos, maxPossAntennaPos);
    }

	// Update is called once per frame
	void Update () {
        if (clampPosition){
            if (DialControl.ClampedPosition(position, minPossAntennaPos, maxPossAntennaPos) > (antennaNeededAntennaPosition + 2) && DialControl.ClampedPosition(position, minPossAntennaPos, maxPossAntennaPos) < (antennaNeededAntennaPosition - 2))
            {
                antennaInPosition = true;
            }
        } else {
            if (DialControl.Position() > (antennaNeededAntennaPosition + 2) && DialControl.Position() < (antennaNeededAntennaPosition - 2)){
                antennaInPosition = true;
            }
        }
       
	}
}
