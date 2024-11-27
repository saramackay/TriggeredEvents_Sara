using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RedLightTrigger : MonoBehaviour
{
    public PlayableDirector DoorClose;
    public PlayableDirector DoorOpen;
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
        DoorClose.Play();
    }

    void OnTriggerExit(Collider other)
    {
        RedLights.SetActive(false);
        WhiteLights.SetActive(true);
        DoorOpen.Play();
    }
}