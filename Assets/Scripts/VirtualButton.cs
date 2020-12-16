using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour virtualButtonBehaviour;
    //private GameObject cube;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBehaviour = GetComponentInChildren<VirtualButtonBehaviour>();
        virtualButtonBehaviour.RegisterEventHandler(this);
        Debug.Log("command reached in the expected position");
        sound = GetComponent<AudioSource>();

        //cube = GameObject.Find("Cube");
        //cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sound.Play();
        //cube.SetActive(true);
        print("*** button Pressed " + vb.VirtualButtonName);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //sound.Stop();
        //cube.SetActive(false);
        print("*** button Released " + vb.VirtualButtonName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
