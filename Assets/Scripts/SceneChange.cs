using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ChangePlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Exit Application");
    }
}
