using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public Collider Collider;
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
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo))
                {
                    if (hitInfo.collider == gameObject.GetComponent<Collider>())
                    {
                        Enable.active = true;
                    }
                }
            }
        }
    }
}