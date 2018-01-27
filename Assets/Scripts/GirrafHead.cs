using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirrafHead : MonoBehaviour {

    public Transform follow;

	// Update is called once per frame
	void Update () {
        this.transform.position = follow.transform.position;
	}
}
