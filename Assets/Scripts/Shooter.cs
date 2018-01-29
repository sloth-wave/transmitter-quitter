using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    Sprite normal, shot;
    public float animTime = 1;
    float timer = 0;

    SpriteRenderer sr;
    void Start() {
<<<<<<< HEAD
        // sr = this.gameObject.getComponent<SpriteRenderer>();
=======
        sr = this.gameObject.GetComponent<SpriteRenderer>();
>>>>>>> 6dadaeb7d10cc281f770c11e022cbf77fffdba24
    }

    void Update()
    {
        if (DialControl.GetButtonDown())
        {
            sr.sprite = shot;
            timer = animTime;
        }

        if (timer < 0) {
            sr.sprite = normal;
        }

        timer -= Time.deltaTime;
    }
}
