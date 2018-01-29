using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOutManager : MonoBehaviour {


    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    GameObject spawn1;

    [SerializeField]
    GameObject spawn2;

    [SerializeField]
    GameObject dogInDress;

    public int numberShot;

    //sounds
    [SerializeField]
    private AudioClip DeathSoundGuy;
    [SerializeField]
    private AudioClip DeathSoundDog;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Use this for initialization
    void Start () {
        numberShot = 0;
        StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {

        if (numberShot == 2)
        {
            Debug.Log("all has been shot");
        }
	}

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(.2f);
        enemyPrefab.transform.position = spawn1.transform.position;
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(.4f);
        dogInDress.transform.position = spawn2.transform.position;
        Instantiate(dogInDress);

    }

    public void PlaySoundGuy()
    {
        audioSource.PlayOneShot(DeathSoundGuy);
    }

    public void PlaySoundDog()
    {
        audioSource.PlayOneShot(DeathSoundDog);
    }

}
