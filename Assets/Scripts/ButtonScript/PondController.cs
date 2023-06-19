using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class PondController : MonoBehaviour 
{
    private bool allPressed;
    private bool red;
    private bool blue;
    private bool yellow;


    [SerializeField] private GameObject redObjectToDestroy;
    [SerializeField] private GameObject blueObjectToDestroy;
    [SerializeField] private GameObject yellowObjectToDestroy;
     private GameObject objectToDestory;

    private void Update()
    {
        if (red && blue && yellow)
        {
            Debug.Log("AllTrue!");
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        string tagOfTheObject = other.gameObject.tag;
    
        //Should be RedCube, BlueCube,YellowCube. Not RedButton.
        
        switch (tagOfTheObject)
        {
            case "RedButton":
                red = true;
                StartCoroutine(SetActiveToFalse(redObjectToDestroy));
                Debug.Log("Red!");
                break;

            case "BlueButton":
                blue = true;
                StartCoroutine(SetActiveToFalse(blueObjectToDestroy));
                Debug.Log("Blue!");
                break;

            case "YellowButton":
                yellow = true;
                StartCoroutine(SetActiveToFalse(yellowObjectToDestroy));
                Debug.Log("Yellow");
                break;
        }

    }

    IEnumerator SetActiveToFalse(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(3f);
        objectToDestroy.SetActive(false);
    }

}


