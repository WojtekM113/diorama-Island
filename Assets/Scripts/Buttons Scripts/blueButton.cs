using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

//boolscriptableobject
public class blueButton : MonoBehaviour
{
    private bool isTrigger;
    
    public DoubleBooleanForRocket checkpoint_02;

    private int keyPressed;

    private void Start()

    {
        checkpoint_02.blueButtonPressed = false;
        keyPressed = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && isTrigger && keyPressed <= 0)
        {
            keyPressed++;
            transform.DOMoveY(10.323f, 1).SetLoops(2, LoopType.Yoyo);
            checkpoint_02.blueButtonPressed = true;
            
             

        }
    }
}
