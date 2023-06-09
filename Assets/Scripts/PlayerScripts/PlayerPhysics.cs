using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour {

    CharacterController controller;

    //private float jumpForce = 5;
    private float velocity;
    private float gravity = -9.81f;
    private int jump = 0;
    private float jumpHeight = 1;
    private float gravityScale = 1;

    private void Start() 
    {
        controller = GetComponent<CharacterController>();

    }

 
    void Update() {

        
        if (Input.GetKeyDown(KeyCode.Space) && jump != 1)
        {
            JumpController();            
        }
        velocity += gravity * gravityScale * Time.deltaTime;
        controller.Move(new Vector3(0, velocity, 0) * Time.deltaTime);
        


    }


    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.collider.tag == "Ground")
        {
            jump = 0;
        }
        
    }


    void JumpController() {
         
        velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
        jump++;
    }
  



    // version if there is not characterController attached.
   /* void GroundCheck() 
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
     */
}
