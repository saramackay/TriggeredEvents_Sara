using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ZombieDoor_Script : MonoBehaviour
{
    public GameObject AnimatedObject;

    private Animator zombieanimator;

    private void Start()
    {
        zombieanimator = AnimatedObject.GetComponent<Animator>();
        zombieanimator.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        zombieanimator.enabled = true;
    }

}