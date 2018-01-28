using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingFruit : MonoBehaviour {

    public float numberOfFruit = 10;

    public Transform[] spawnPoints;

    public float timeBetweenSpawn = 3;
    float timer = 0;
	// Update is called once per frame
	void Update () {

        if (timer < 0) {
            GameObject go = new GameObject();
            FruitBehaviour fruit = go.AddComponent<FruitBehaviour>();
            fruit.gameObject.transform.position = spawnPoints[Mathf.RoundToInt(Random.Range(0, spawnPoints.Length))].transform.position;
            timer = timeBetweenSpawn;
        }

        timer -= Time.deltaTime;
		
	}
}
