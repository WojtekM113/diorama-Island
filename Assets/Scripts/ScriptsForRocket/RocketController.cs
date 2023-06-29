using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RocketController : MonoBehaviour
{
     
  
    
    [SerializeField] private GameObject emptyRocketObj;
    [SerializeField] private NumberScriptableObject number;
    
 

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
        //if(statement 1 && statement2){}
            
       
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
