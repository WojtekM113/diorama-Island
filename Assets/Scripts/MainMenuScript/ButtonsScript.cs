using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class ButtonsScript : MonoBehaviour
{
    

    public void OnStartGameClick()
    {
        SceneManager.LoadScene("SampleScene");
    }


   public void onExitClick()
    {
        Application.Quit();
    }


  

}
