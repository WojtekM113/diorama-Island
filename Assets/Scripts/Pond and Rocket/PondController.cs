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
    private GameObject objectToDestroy;
    
    [SerializeField] private ParticleSystem pondParticles;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    public delegate void ObjectsTrueAction();
    public  static event ObjectsTrueAction OnAllTrue;


 
    public DoubleBooleanForRocket checkpoint_01;
    


    private void Awake()
    {
        
    }

    private void Update()
    {
        if (red && blue && yellow)
        {
            StartCoroutine(WaitBeforeEvent());
            checkpoint_01.cubesTrue = true;

        }

      
         
         
    }

    private void Start()
    {
        pondParticles.Stop();
        
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
                 
                break;

            case "BlueButton":
                blue = true;
                StartCoroutine(SetActiveToFalse(blueObjectToDestroy));
               
                break;
            

            case "YellowButton":
                yellow = true;
                StartCoroutine(SetActiveToFalse(yellowObjectToDestroy));
                 
                break;
        }

    }

    IEnumerator SetActiveToFalse(GameObject objectToDestroy)
    {
        
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(audioClip, 0.7f);
        yield return new WaitForSeconds(2f);
        pondParticles.Play();
        yield return new WaitForSeconds(3f);
        objectToDestroy.SetActive(false);
        pondParticles.Stop();
       
    }

    private IEnumerator WaitBeforeEvent()
    {
        yield return new WaitForSeconds(4f);

       
        
        if (OnAllTrue != null)
        {
            OnAllTrue();
             

        }
 
    }

  
}


