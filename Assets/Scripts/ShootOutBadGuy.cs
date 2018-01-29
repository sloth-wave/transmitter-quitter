using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOutBadGuy : MonoBehaviour {

    [SerializeField]
    GameObject _enemyExplosionPreFab;

    [SerializeField]
    private AudioClip DeathSound;
    AudioSource audioSource;

    shotOutSpawnEnemy badguyScript;

  

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        badguyScript = GetComponent<shotOutSpawnEnemy>();
    }


	// Use this for initialization
	void Start () {
        
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.PlayOneShot(DeathSound);
        badguyScript.AllShot();
        Instantiate(_enemyExplosionPreFab, this.transform.position, Quaternion.identity);
        this.gameObject.SetActive(false);


    }


}
