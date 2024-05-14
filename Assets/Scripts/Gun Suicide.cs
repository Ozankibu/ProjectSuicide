using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GunSuicide : MonoBehaviour , IInteractible
{

    [SerializeField] float remainingTime2 = 2;

    public GameObject player;
    public Animator animator;
    public Transform target;
    public BoxCollider compcollider;

    public bool isRunning = false;
    public void Interact()
    {
        Destroy(compcollider);
        gameObject.transform.parent = player.transform;
        animator.SetTrigger("Trigger");

        StartTimer();

    }

    public void StartTimer()
    {
        isRunning = true;
    }

    void Update()
    {
        if (isRunning == false)
        {
            Debug.Log(remainingTime2);
        }

        else if (isRunning == true)
        {
            remainingTime2 -= Time.deltaTime;

            if (remainingTime2 <= 0)
            {
                SceneManager.LoadScene("END2");
            }
        }


    }
}
