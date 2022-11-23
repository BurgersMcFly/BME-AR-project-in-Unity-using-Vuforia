using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUnlockButton : MonoBehaviour
{
    public GameObject DisabledGameObject;
    public GameObject Enable;
    public GameObject Padlock;

    void start()
    {

    }
    void Update()
    {
        if (!DisabledGameObject.activeSelf)
        {
            Enable.SetActive(true);
        }
        if (Padlock.activeSelf)
        {
            Enable.SetActive(false);
        }

    }
}
