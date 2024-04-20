using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GunSuicide : MonoBehaviour , IInteractible
{
    public GameObject player;
    public Animator animator;
    public Transform target;
    public void Interact()
    {
        gameObject.transform.parent = player.transform;
        animator.SetTrigger("Trigger");


    }


}
