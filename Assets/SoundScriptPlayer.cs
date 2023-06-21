using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScriptPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;
    void Start()
    {
        audioSource.clip = audioClip;
        audioSource.volume = 0.7f;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
