using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;    
public class ColliderManager : MonoBehaviour  
{
    AudioSource sound; // 음계소리
    // private static ParticleSystem fireFront;     
    // private static ParticleSystem fireBack;       
    // Use this for initialization     
    void Start ()     
    {   
        sound = GetComponent<AudioSource>();
        // fireFront = GameObject.FindGameObjectWithTag("FireA").GetComponent<ParticleSystem>();
        // fireBack = GameObject.FindGameObjectWithTag("FireB").GetComponent<ParticleSystem>();     
    }       
    void OnTriggerEnter(Collider other)     
    {        
        if (other is SphereCollider)        
        {           
            // fireFront.Play(true);
            sound.Play();        
            Debug.Log("[Tap] Sound -> " + other.name);  
        }
        else if (other is MeshCollider)
        {
        }     
    }     
    void OnTriggerExit(Collider other)  
    {   
        // if (fireFront.isPlaying == true)    
        //     fireFront.Stop(true);       
        //         if (fireBack.isPlaying == true)      
        //             fireBack.Stop(true);     
    } 
}
