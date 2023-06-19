using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
     private float speed = 13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") *Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical")*Time.deltaTime;

        Vector3 move = transform.right * horizontalInput  + transform.forward * verticalInput;

        characterController.Move(move * speed * Time.deltaTime * 60);
    }
}
