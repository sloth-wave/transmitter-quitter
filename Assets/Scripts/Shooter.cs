using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    void Update()
    {
        if (DialControl.GetButtonDown())
        {
            RaycastHit2D[] hit = Physics2D.RaycastAll(this.transform.position, this.transform.up);
            for (int i = 0; i < hit.Length; i++)
            {
                if (hit[i].transform.tag == "Enemy")
                {
                    Destroy(hit[i].transform.gameObject, 0);
                    return;
                }
            }
        }
    }
}
