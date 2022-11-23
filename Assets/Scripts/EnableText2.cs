using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableText2 : MonoBehaviour
{

    public Animator anim;
    public Collider Collider;

    void start()
    {

    }

    void Update()
    {
        // for (int i = 0; i<Input.touchCount; ++i) 
        {
            // if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("DefaultState"))
            // if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            if (Input.GetMouseButtonDown(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo))
                {
                    if (hitInfo.collider == gameObject.GetComponent<Collider>())
                    {
                        anim.Play("Text2");
                    }
                }
            }
        }
    }
}