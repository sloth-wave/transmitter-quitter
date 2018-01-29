using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    float _speed = 10.0f;
    [SerializeField]
    GameObject explopsion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += this.transform.up*Time.deltaTime*_speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(this.gameObject);

    }
}
