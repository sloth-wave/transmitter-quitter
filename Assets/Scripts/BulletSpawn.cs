using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;

    [SerializeField]
    private AudioClip pew;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
        if (DialControl.GetButtonDown()) {
            audioSource.PlayOneShot(pew, 0.7F);
            GameObject.Instantiate(bullet, this.transform.position, Quaternion.identity, null);
        }
	}
}
