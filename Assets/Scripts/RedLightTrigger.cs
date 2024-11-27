using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RedLightTrigger : MonoBehaviour
{
    //public PlayableDirector LightTimeline;
    public GameObject RedLights;
    public GameObject WhiteLights;

    private void Start()
    {
        RedLights.SetActive(false);
        WhiteLights.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        RedLights.SetActive(true);
        WhiteLights.SetActive(false);
        //LightTimeline.Play();
    }

    void OnTriggerExit(Collider other)
    {
        RedLights.SetActive(false);
        WhiteLights.SetActive(true);
        //LightTimeline.Play();
    }
}