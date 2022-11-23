using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableText3 : MonoBehaviour
{

    public Animator anim;

    void start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Text3"))
        {
            anim.Play("none");
            gameObject.active = false;
        }
    }
}
