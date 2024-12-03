using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ghost_Script : MonoBehaviour
{
    public GameObject AnimatedObject;
    private Animator Zombie;

    private void Start()
    {
        Zombie = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Zombie.enabled = true;
    }
}
