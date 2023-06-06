using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour {

    CharacterController controller;

    private float jumpForce = 5;
    private float velocity;
    float gravity = -9.81f;
    private int jump = 0;
    private bool isGrounded;


    private void Start() {
        controller = GetComponent<CharacterController>();

    }

 
     
    

    void Update() {
        
        velocity += gravity * Time.deltaTime;
        GroundCheck();
        DisableGravity();



        if (Input.GetKeyDown(KeyCode.Space) && jump != 1)
        {
            velocity = jumpForce;
            jump++;

        }



        controller.Move(new Vector3(0, velocity, 0) * Time.deltaTime);

  


    }



  

    void GroundCheck() 
    {
        if (Physics.Raycast(transform.position, Vector3.down, 0.5f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
        

    private void DisableGravity() 
    {
        if (isGrounded && velocity < 0)
        {
            velocity = 0;
            jump = 0;
        }
    }

}
