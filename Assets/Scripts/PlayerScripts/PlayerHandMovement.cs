using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandMovement : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 250f;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

     
      
        
        
        xRotation -= mouseY;        
        xRotation = Mathf.Clamp(xRotation, -40f, 40f);
        this.gameObject.transform.rotation = Quaternion.Euler(xRotation, 0, 0);

    }
}
