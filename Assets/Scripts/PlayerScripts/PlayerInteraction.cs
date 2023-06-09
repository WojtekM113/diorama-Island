using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<IInteract>() != null && Input.GetKeyDown(KeyCode.E))
        {
                        
                other.GetComponent<IInteract>().Interact();                    
        }
    }

}
