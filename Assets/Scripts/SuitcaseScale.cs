using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuitcaseScale : MonoBehaviour

{
    public GameObject DisabledGameObject;
    public Animator anim;

    void start()
    {

    }
    void Update()
    {
        if (!DisabledGameObject.activeSelf)
        {
            anim.Play("SuitcaseScale");
        }

        }
    }