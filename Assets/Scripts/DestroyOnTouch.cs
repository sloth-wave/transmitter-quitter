using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll){
        if (coll.transform.tag == "Enemy") {
            Destroy(coll.gameObject, 0);
        }
    }
}
