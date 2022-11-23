using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingEvents : MonoBehaviour
{
    public GameObject KillSequence;
    public GameObject KillReleaseAirway;
    public GameObject AlmostOver;
    public GameObject GameOver;
    public GameObject UpdateCode;
    public GameObject KillOldCode;



    void start()
    {

    }

    public void Extend()
    {
        AlmostOver.SetActive(true);
        KillReleaseAirway.SetActive(false);
        KillSequence.SetActive(false);

    }
    public void Pickup()
    {

        GameOver.SetActive(true);
        KillReleaseAirway.SetActive(false);
        KillSequence.SetActive(false);

    }
    public void ResetScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Ending()
    {
        AlmostOver.SetActive(false);
        UpdateCode.SetActive(true);
        KillOldCode.SetActive(false);
    }
}