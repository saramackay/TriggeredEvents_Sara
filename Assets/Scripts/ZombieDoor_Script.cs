using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ZombieDoor_Script : MonoBehaviour
{
    public PlayableDirector zombiedoor;
    bool played = false;

    void OnTriggerEnter(Collider other)
    {
        if (played == false)
        {
            zombiedoor.Play();
            played = true;
        }
    }

}