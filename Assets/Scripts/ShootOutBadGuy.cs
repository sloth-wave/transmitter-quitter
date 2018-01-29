using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOutBadGuy : MonoBehaviour {

    //[SerializeField]
    //GameObject enemyPrefab;

    //[SerializeField]
    //GameObject spawn1;

    [SerializeField]
    GameObject _enemyExplosionPreFab;

    [SerializeField]
    private AudioClip DeathSound;
    AudioSource audioSource;




	// Use this for initialization
	void Start () {

        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //IEnumerator SpawnEnemy()
    //{
    //    yield return new WaitForSeconds(1);
    //    enemyPrefab.transform.position = spawn1.transform.position;
    //    Instantiate(enemyPrefab);

    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.PlayOneShot(DeathSound, 0.7F);
            Destroy(this.gameObject);


    }
}
