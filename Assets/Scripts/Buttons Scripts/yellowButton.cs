using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowButton : MonoBehaviour
{
    public delegate void ButtonPressed();

    private bool isTrigger;

    public static event ButtonPressed OnButtonPressed;


    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigger && OnButtonPressed != null)
        {
            OnButtonPressed();
        }
    }
}
