using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class PickUpTheCube : MonoBehaviour {


    bool _isTouching;
    private bool _keysPressed;
    [SerializeField] GameObject handGameObject;
    [SerializeField] private GameObject objectToPickUp;
     [SerializeField] private Rigidbody cubeRigidBody;
    private int keyPressed;


    private void Start()
    {
        cubeRigidBody = objectToPickUp.GetComponent<Rigidbody>();
    }

    void Update() 
   {
       
       Debug.Log(_keysPressed);
       
        KeysPressedController();
        if (_isTouching && Input.GetKeyDown(KeyCode.E))
        {
            keyPressed++;
            Debug.Log("PickedUp");
            if (_keysPressed)
            {
                PickUpCube();
            }
             else 
            {
                DropCube();
            }
                
        }
        
   }

    void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") 
        {
            _isTouching = false;
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            _isTouching = true;
        }
    }

    void PickUpCube()
    {
        cubeRigidBody.isKinematic = true;
        objectToPickUp.transform.position = handGameObject.transform.position;
        objectToPickUp.transform.parent = handGameObject.transform;
    }

    void DropCube()
    {
        cubeRigidBody.isKinematic = false;
        objectToPickUp.transform.parent = null;
    }
    
    
    void KeysPressedController()
    {
        if (keyPressed == 0)
        {
            _keysPressed = true;
        }
        else if (keyPressed == 1)
        {
            _keysPressed = false;
            keyPressed = -1;
        }
            
    }
}
