using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbtnSol : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour virtualButtonBehaviour;
    private AudioSource sound;
    public GameObject ps;
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBehaviour = GetComponentInChildren<VirtualButtonBehaviour>();
        virtualButtonBehaviour.RegisterEventHandler(this);
        Debug.Log("command reached in the expected position");
        
        sound = GetComponent<AudioSource>();

        ps = GameObject.Find("PsSol");
        ps.SetActive(false);

        star = GameObject.Find("StarSol");
        star.SetActive(false);    
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sound.Play();
        ps.SetActive(true);

        star.SetActive(true);
        print("*** button Pressed " + vb.VirtualButtonName);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ps.SetActive(false);
        star.SetActive(false);
        print("*** button Released " + vb.VirtualButtonName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
