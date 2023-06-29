using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public DoubleBooleanForRocket checkIfAllTrue;
    [SerializeField] private GameObject emptyRocketObj;
    

    private void OnEnable()
    {
        yellowButton.OnButtonPressed += PlayRocketAnimationObj;
    }

    private void OnDisable()
    {
        yellowButton.OnButtonPressed -= PlayRocketAnimationObj;
    }


    private void PlayRocketAnimationObj()
    {
        if(checkIfAllTrue.cubesTrue && checkIfAllTrue.blueButtonPressed)
            StartCoroutine(CountTOTheStart());

    }

    IEnumerator CountTOTheStart()
    {
        emptyRocketObj.transform.DOMoveY(100, 10).SetDelay(6f);
        for (int i = 0; i<5; i++)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(i+1);

        }
        
    }
 
}
