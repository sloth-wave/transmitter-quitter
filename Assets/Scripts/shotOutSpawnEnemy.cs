using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotOutSpawnEnemy : MonoBehaviour {

    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    GameObject spawn1;

    [SerializeField]
    GameObject spawn2;

    [SerializeField]
    GameObject dogInDress;



	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(.2f);
        enemyPrefab.transform.position = spawn1.transform.position;
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(.3f);
        dogInDress.transform.position = spawn2.transform.position;
        Instantiate(dogInDress);

    }
}
