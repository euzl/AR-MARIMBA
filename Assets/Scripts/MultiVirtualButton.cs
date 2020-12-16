using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultiVirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private VirtualButtonBehaviour[] _vrButton;
    
    // Start is called before the first frame update
    void Start()
    {
        _vrButton = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i=0; i<_vrButton.Length; ++i)
        {
            _vrButton[i].RegisterEventHandler(this);
        }
    }
    
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("*** button Pressed " + vb.VirtualButtonName);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        print("*** button Released " + vb.VirtualButtonName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
