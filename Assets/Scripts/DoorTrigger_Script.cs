using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DoorTrigger_Script : MonoBehaviour
{

        public PlayableDirector timeline;
        bool Played = false;

        void OnTriggerEnter(Collider other)
        {
            if (Played == false)
            {
                timeline.Play();
                Played = true;
            }
        }
    }
