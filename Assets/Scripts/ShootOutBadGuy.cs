using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOutBadGuy : MonoBehaviour {

    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    GameObject spawn1;

    [SerializeField]
    GameObject spawn2;


	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(5);
        enemyPrefab.transform.position = spawn1.transform.position;
        Instantiate(enemyPrefab);

    }
}
