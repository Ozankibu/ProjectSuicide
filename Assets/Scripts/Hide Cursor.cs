using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        CursorLockMode lockMode = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}