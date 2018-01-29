using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVAntenna : MonoBehaviour {

    public Animator anim;

    public bool antennaInPosition = false;
    public float maxPossAntennaPos, minPossAntennaPos;
    public float sensitivity = 1f;

    public bool clampPosition = false;

    public float antennaNeededAntennaPosition = 45; //degrees

    public float position = 0;

    void Start() {
        antennaNeededAntennaPosition = Random.Range(minPossAntennaPos, maxPossAntennaPos);
    }

	// Update is called once per frame
	void Update () {
        position = DialControl.ClampedPosition(position, minPossAntennaPos, maxPossAntennaPos) ;

        if (clampPosition){
            if (position < (antennaNeededAntennaPosition + 2) && position > (antennaNeededAntennaPosition - 2)){
                antennaInPosition = true;
                anim.SetTrigger("Pan Down");
            }
        } else {
            if (DialControl.Position() < (antennaNeededAntennaPosition + 2) && DialControl.Position() > (antennaNeededAntennaPosition - 2)){
                antennaInPosition = true;
                anim.SetTrigger("Pan Down");
            }
        }


	}

    public void antennaCheat(){
      anim.SetTrigger("Pan Down");
    }
}
