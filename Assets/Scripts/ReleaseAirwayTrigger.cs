using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseAirwayTrigger : MonoBehaviour
{



    public GameObject DisabledGameObject;
    public GameObject Enable;
    public GameObject Hide1;
    public GameObject Hide2;
    public GameObject Hide3;

    void start()
    {

    }

    void Update()
    {
        // for (int i = 0; i<Input.touchCount; ++i) 
        {
            // if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("DefaultState"))
            // if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            if (!DisabledGameObject.activeSelf)
            {
                Enable.SetActive(true);
            }
            if (Hide1.activeSelf)
            {
                Enable.SetActive(false);
            }
            if (Hide2.activeSelf)
            {
                Enable.SetActive(false);
            }
            if (Hide3.activeSelf)
            {
                Enable.SetActive(false);
            }
        }
    }
}