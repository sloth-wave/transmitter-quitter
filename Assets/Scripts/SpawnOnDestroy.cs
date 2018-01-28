using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour {

    public GameObject obj;

	void OnDestroy () {
        GameObject.Instantiate(obj, this.transform.position, Quaternion.identity);
	}
}
