using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadChoiceTrigger : MonoBehaviour
{

    public GameObject DisableGameObject;
    public GameObject Enable;

    void start()
    {

    }

    public void SequenceEnabler()
    {
        DisableGameObject.SetActive(false);
        Enable.SetActive(true);
    }
    public void SequenceDisabler()
    {
        DisableGameObject.SetActive(true);
        Enable.SetActive(false);
    }
}