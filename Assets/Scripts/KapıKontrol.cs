using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıKontrol : MonoBehaviour , IInteractible
{
    private float turnDeg = 90f;
    public bool isOpen = false;


    public void Interact()
    {

        Debug.Log("1");

        if (isOpen == false)
        {
            gameObject.transform.Rotate(0, turnDeg, 0);
            if (isOpen == false)
            {
                isOpen = true;
            }

            else if (isOpen == true)
            {
                isOpen = false;
            }
        }
        else if (isOpen == true)
        {
            gameObject.transform.Rotate(0, turnDeg * -1, 0);
            if (isOpen == false)
            {
                isOpen = true;
            }

            else if (isOpen == true)
            {
                isOpen = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
