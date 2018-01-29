using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingFruit : MonoBehaviour {

    public Sprite[] fruits;

    public Sprite[] slicedFruitsSprites;

    [Space]

    public float numberOfFruit = 10;

    public Transform[] spawnPoints;

    public float timeBetweenSpawn = 3;
    public float timer = 0;

    public int layer = 0;

    public AudioClip sound;
    AudioSource source;
	// Update is called once per frame
    void Start(){
      source = this.gameObject.AddComponent<AudioSource>();

    }

	void Update () {
        if(timer > timeBetweenSpawn || timer >= 0.2){
          GameObject go = new GameObject();
          go.transform.position = spawnPoints[Mathf.RoundToInt(Random.Range(0, spawnPoints.Length))].transform.position;
          FruitBehaviour fruit = go.AddComponent<FruitBehaviour>();
          fruit.fruits = fruits;
          fruit.slicedFruitsSprites = slicedFruitsSprites;
          fruit.layer = layer;
          timer = 0;
          fruit.audioSource = source;
          fruit.cutFruit = sound; 
        }

        timeBetweenSpawn -= Time.deltaTime / 10;

        timer += Time.deltaTime;

	}
}
