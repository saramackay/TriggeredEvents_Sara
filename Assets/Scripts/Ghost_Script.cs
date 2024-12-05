using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ghost_Script : MonoBehaviour
{
    public PlayableDirector zombie;
    bool played = false;

    void OnTriggerEnter(Collider other)
    {
        if (played == false)
        {
            zombie.Play();
            played = true;
        }
    }

}