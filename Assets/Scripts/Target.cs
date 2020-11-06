using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)     
    {        
        sound.Play();
        Debug.Log("[Target] Tapped!");  
    }     
    void OnTriggerExit(Collider other)  
    {    
    } 
}
