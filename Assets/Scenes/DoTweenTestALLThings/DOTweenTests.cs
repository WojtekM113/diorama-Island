using System;
using DG.Tweening;
using UnityEngine;

namespace Scenes.DoTweenTestALLThings
{
    public class DOTweenTests : MonoBehaviour
    {
        public GameObject box;

        void Start()
        {

            box.SetActive(false);

        }

        // Update is called once per frame
     
         private void OnEnable()    
        {
            PondController.OnAllTrue += PlayRocketAnimation;
        }

        private void OnDisable()
        {
            PondController.OnAllTrue -= PlayRocketAnimation;
        }

        private void PlayRocketAnimation()
        {
            box.SetActive(true);
        }
    }
}
