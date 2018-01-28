using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
	
	void Update () {
        if (DialControl.GetButtonDown()) {
            GameObject.Instantiate(bullet, this.transform.position, Quaternion.identity, null);
        }
	}
}
