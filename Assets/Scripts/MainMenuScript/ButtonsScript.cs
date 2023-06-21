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

   public void OnSettingsClick()
   {
       SceneManager.LoadScene("Settings");
   }

   public void onExitClick()
    {
        Application.Quit();
    }

   public void onGoBackButtonClick()
   {
       SceneManager.LoadScene("MainMenu");
   }

  

}
