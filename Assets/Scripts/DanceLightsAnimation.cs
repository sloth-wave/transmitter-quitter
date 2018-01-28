using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceLightsAnimation : MonoBehaviour {

    public Animation anim;

    private void OnEnable()
    {
        anim = GetComponent<Animation>();
        anim.Play(anim.clip.name);
    }
}
