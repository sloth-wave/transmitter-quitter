using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootOutDogInADress : MonoBehaviour {

    //[SerializeField]
    //GameObject spawn1;

    [SerializeField]
    GameObject dogInADress;

    [SerializeField]
    GameObject sadDogInADress;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(this.gameObject);


    }
}
