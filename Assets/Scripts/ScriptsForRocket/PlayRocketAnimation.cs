using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRocketAnimation : MonoBehaviour
{

    [SerializeField] private GameObject emptyRocketObj;
        // [SerializeField] private CanUseButtonNumber canUseButtonNumber;

    private void Start()
    {
        emptyRocketObj.SetActive(false);
        
    }

    private void OnEnable()
    {
        PondController.OnAllTrue += PlayRocketAnimationObj;
    }

    private void OnDisable()
    {
        PondController.OnAllTrue -= PlayRocketAnimationObj;
    }


    private void PlayRocketAnimationObj()
    {
        // if (scriptableObject){
        
        emptyRocketObj.SetActive(true);
        
        // }
    }

 
}
