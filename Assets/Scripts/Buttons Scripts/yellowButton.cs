using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class yellowButton : MonoBehaviour
{
    public delegate void ButtonPressed();

    private bool isTrigger;

    public static event ButtonPressed OnButtonPressed;
    
    private int keyPressed; 
    
    

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigger && OnButtonPressed != null && keyPressed <= 0)
        {
            keyPressed++;
            transform.DOMoveZ(-7.634f, 1).SetLoops(2, LoopType.Yoyo);
            OnButtonPressed();
        }
    }

    private void Start()
    {
        keyPressed = 0;
    }
}
