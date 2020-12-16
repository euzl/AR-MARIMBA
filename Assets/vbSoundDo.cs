using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbSoundDo : MonoBehaviour
{
    public GameObject vbBtnObj;
    public AudioSource sound;
    VirtualButtonBehaviour vbb;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("DoBtn");
        vbb = GetComponentsInChildren<VirtualButtonBehaviour>();
        vbb[0].RegisterOnButtonPressed(onButtonPressed);
        // vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        // vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(onButtonReleased);

        
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