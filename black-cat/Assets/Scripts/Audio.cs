using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton = GameObject.Find("Playbutton").GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

}
