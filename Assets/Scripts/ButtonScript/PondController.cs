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
  
  
  [SerializeField] GameObject redObjectToDestroy;
  private GameObject blueObjectToDestroy;
  private GameObject yellowObjectToDestroy;
  private GameObject objectToDestory;
  
  
  private void CheckPressed()
  {
      if (red && blue && yellow)
      {
          allPressed = true;
      }
  }

   private void OnTriggerEnter(Collider other)
  {
     if (other.CompareTag("RedButton"))
     {
      Debug.Log("RedPressed!");
      red = true;
      
     
      StartCoroutine(DestroyRedObject());
     }

     if (other.CompareTag("BlueButton"))
     {
         Debug.Log("BluePressed!");
         blue = true ;
         
         StartCoroutine(DestroyBlueObject());
     }
   
     if (other.CompareTag("YellowButton"))
     {
         Debug.Log("YellowPressed!");
         yellow = true ;
         
         StartCoroutine(DestroyYellowObject());
     }
  }

 

   IEnumerator DestroyRedObject()
   {
       yield return new WaitForSeconds(3f);
       redObjectToDestroy.SetActive(false);
   }

   IEnumerator DestroyBlueObject()
   {
       yield return new WaitForSeconds(3f);
       blueObjectToDestroy.SetActive(false);

   }
   IEnumerator DestroyYellowObject()
   {
       yield return new WaitForSeconds(3f);
       yellowObjectToDestroy.SetActive(false);

   }
 
}
