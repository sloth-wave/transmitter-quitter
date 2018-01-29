using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOutDog : MonoBehaviour {

    [SerializeField]
    GameObject _enemyExplosionPreFab;



    SOutManager soutManager;



    private void Awake()
    {


        soutManager = FindObjectOfType<SOutManager>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        soutManager.PlaySoundDog();
        Instantiate(_enemyExplosionPreFab, this.transform.position, Quaternion.identity);
        this.gameObject.SetActive(false);

    }
}
