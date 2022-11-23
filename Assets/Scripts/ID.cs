using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ID : MonoBehaviour

{
    private GameObject[] SplatText;
    public Animator anim;

    void start()
    {
        

    }
    void Update()
    {
        GameObject[] SplatText;
        SplatText = GameObject.FindGameObjectsWithTag("SplatText");
        if (SplatText.Length == 0)
        {
            anim.Play("ID");
        }
        if (Input.GetMouseButtonDown(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("ID"))
        {
            anim.Play("none");
            gameObject.active = false;
        }
    }
}
