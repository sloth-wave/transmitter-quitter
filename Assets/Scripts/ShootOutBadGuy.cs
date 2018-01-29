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




	// Use this for initialization
	void Start () {

        //StartCoroutine(SpawnEnemy());
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

            Destroy(this.gameObject);


    }
}
