using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTheCube : MonoBehaviour, IInteract {


    bool isTouching;

    public void Interact() {
         isTouching = true;

    }


   void Update() {
       
        if (isTouching && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("PickedUp");
        }
    }

    void OnTriggerExit(Collider other) {
        isTouching = false;
    }


    void PickUpCube() {

    }
}
