using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCovid : MonoBehaviour
{

    public Animator anim;

    void start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("ShowCovid"))
        {
            anim.Play("none");
            gameObject.active = false;
        }
    }
}
