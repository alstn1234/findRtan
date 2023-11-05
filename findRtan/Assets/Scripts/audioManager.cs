using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip bgmusic;
    public AudioSource audioSoure;
    // Start is called before the first frame update
    void Start()
    {
        audioSoure.clip = bgmusic;
        audioSoure.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
