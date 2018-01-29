using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceArrow : MonoBehaviour {

    Dance dance;

    public void Awake()
    {
        dance = FindObjectOfType<Dance>();
    }

    public void OnTriggerEnter2D (Collider2D other)
    {
        dance.GetComponent<Dance>();
        dance.Hit();
    }
}
