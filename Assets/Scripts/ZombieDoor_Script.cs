using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ZombieDoor_Script : MonoBehaviour
{

    public PlayableDirector Zombietimeline;
    bool Played = false;

    void OnTriggerEnter(Collider other)
    {
        if (Played == false)
        {
            Zombietimeline.Play();
            Played = true;
        }
    }
}

