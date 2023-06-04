using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 250f;
    public Transform playerTransform;

    float xRotation = 0f;
  
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

   
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerTransform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        xRotation = Mathf.Clamp(xRotation, -40f, 40f);


    }
}
