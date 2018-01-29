using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootOutBadGuy : MonoBehaviour {

    [SerializeField]
    GameObject _enemyExplosionPreFab;



    SOutManager soutManager;

  

    private void Awake()
    {
        

        soutManager = FindObjectOfType<SOutManager>();
    }


	// Use this for initialization
	void Start () {
        
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        soutManager.PlaySoundGuy();
        Instantiate(_enemyExplosionPreFab, this.transform.position, Quaternion.identity);
        this.gameObject.SetActive(false);

    }



}
