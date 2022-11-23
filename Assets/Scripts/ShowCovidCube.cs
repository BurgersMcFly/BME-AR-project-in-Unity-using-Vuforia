using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCovidCube : MonoBehaviour
{


    
    public GameObject DisabledGameObject;
    public GameObject Enable;

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
        }
    }
}
