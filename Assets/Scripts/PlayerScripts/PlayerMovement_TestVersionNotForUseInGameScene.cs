using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_TestVersionNotForUseInGameScene : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
     private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");    

        Vector3 move = transform.right* horizontalInput *Time.deltaTime + transform.forward* verticalInput * Time.deltaTime;

        characterController.Move(move * speed * Time.deltaTime * 60);
    }
}
