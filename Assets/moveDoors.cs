using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class moveDoors : MonoBehaviour
{
    private void OnEnable()
    {

        PondController.OnAllTrue += MoveDoors;
    }

    private void OnDisable()
    {
        PondController.OnAllTrue -= MoveDoors;
    }


    private void MoveDoors()
    {
        transform.DORotate(new Vector3(0, 60, 0), 3);
    }
}
