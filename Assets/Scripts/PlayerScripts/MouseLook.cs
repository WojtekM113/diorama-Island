using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {




    [SerializeField] private float mouseSensitivity = 250f;
    public Transform playerTransform;

     float xRotation = 0f;

    void Start() {

        //We used it to make cursor locked in game 
        Cursor.lockState = CursorLockMode.Locked;
    }


    void LateUpdate() {

        //mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotating X of the player and whole object
        playerTransform.Rotate(Vector3.up * mouseX);


        //rotating only child by using localRotation?
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40f, 40f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);




    }

}

