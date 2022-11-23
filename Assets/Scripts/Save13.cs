using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save13 : MonoBehaviour
{
    public GameObject DisabledGameObject;
    public GameObject Enable;

    void start()
    {

    }
    void Update()
    {
        if (!DisabledGameObject.activeSelf)
        {
            Enable.SetActive(true);
        }
    }
}