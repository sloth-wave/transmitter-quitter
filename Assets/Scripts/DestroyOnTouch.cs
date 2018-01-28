using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {

	public int killCount = 0;

	void Update () {

	}

    void OnCollisionEnter2D(Collision2D coll){
        if (coll.transform.tag == "Enemy") {
						killCount++;
				    Destroy(coll.gameObject, 0);
        }
    }
}
