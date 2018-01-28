using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBehaviour : MonoBehaviour {

    public Sprite[] fruits;

    public Sprite[] slicedFruitsSprites;

    public GameObject[] slicedFruits;

    public bool lockedPosition = false;
    public bool lockedSlices   = false;

    public int layer = 0;

    CircleCollider2D collider;

    SpriteRenderer render;
    Rigidbody2D rigid;

    // Use this for initialization
    void Start() {
        render = this.gameObject.AddComponent<SpriteRenderer>();
        int fruit = Mathf.RoundToInt(Random.Range(0, fruits.Length - 1));
        render.sprite = fruits[fruit];
        render.sortingOrder = layer;

        rigid = this.gameObject.AddComponent<Rigidbody2D>();
        collider = this.gameObject.AddComponent<CircleCollider2D>();

        this.transform.tag = "Enemy";

        slicedFruits = new GameObject[2];
        if (lockedPosition)
            rigid.constraints = RigidbodyConstraints2D.FreezePosition;

        for (int i = 0; i < 2; i++){
            slicedFruits[i] = new GameObject();
            slicedFruits[i].transform.parent = this.transform;
            slicedFruits[i].transform.position = this.transform.position;
            slicedFruits[i].gameObject.AddComponent<SpriteRenderer>().sprite = slicedFruitsSprites[2 * fruit + i];
            slicedFruits[i].AddComponent<Rigidbody2D>();
            slicedFruits[i].SetActive(false);
        }

	}

	// Update is called once per frame
	void Update () {

	}

    void OnDestroy(){
        for (int i = 0; i < 2; i++) {
            slicedFruits[i].transform.parent = null;
            slicedFruits[i].SetActive(true);
            slicedFruits[i].gameObject.GetComponent<SpriteRenderer>().sortingOrder = layer;

            if (lockedSlices) {
                slicedFruits[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            }
            else {
                slicedFruits[i].GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-10, 10), 0);
            }
        }
    }
}
