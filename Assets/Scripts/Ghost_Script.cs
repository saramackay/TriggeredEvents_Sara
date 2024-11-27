using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ghost_Script : MonoBehaviour
{
    public PlayableDirector GhostTimeline;
    bool Played = false;

    void OnTriggerEnter(Collider other)
    {
        if (Played == false)
        {
            GhostTimeline.Play();
            Played = true;
        }
    }
}
