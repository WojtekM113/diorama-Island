using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<IInteract>() != null)
        {
            other.GetComponent<IInteract>().Interact();
        }
    }
    
    
}

