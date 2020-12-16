using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbSoundSol : MonoBehaviour
{
    public GameObject vbBtnObj;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
        vbBtnObj = GameObject.Find("SolBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(onButtonReleased);
        
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        sound.Play();
        Debug.Log("BTN Pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BTN Realesed");
    }
}