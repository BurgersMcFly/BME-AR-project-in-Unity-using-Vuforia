using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideButton : MonoBehaviour
{
    public GameObject EnabledGameObject;
    public GameObject Enable;

    void start()
    {

    }
    void Update()
    {
        if (EnabledGameObject.activeSelf)
        {
            Enable.SetActive(true);
        }
        else if (!EnabledGameObject.activeSelf)
        {
            Enable.SetActive(false);
        }
        
    }
}
