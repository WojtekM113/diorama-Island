using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TurnColorScript : MonoBehaviour
{

    void OnEnable()
    {
        PondController.OnAllTrue += TurnColor;
    }

    private void OnDisable()
    {
        PondController.OnAllTrue -= TurnColor;
    }
    
    void TurnColor()
    {
        Color color = new Color(255, 0, 0);
        GetComponent<Renderer>().material.color = color;
    }
}
