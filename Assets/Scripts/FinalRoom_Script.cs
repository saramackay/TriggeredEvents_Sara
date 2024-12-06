using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FinalRoom_Script : MonoBehaviour
{
    public PlayableDirector finalroom;
    bool played = false;

    void OnTriggerEnter(Collider other)
    {
        if (played == false)
        {
            finalroom.Play();
            played = true;
        }
    }
}
