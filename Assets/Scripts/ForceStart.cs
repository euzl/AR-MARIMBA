using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 강제로 첫 Scene을 결정해주는 Script
public class ForceStart : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name.CompareTo("StartScene") != 0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
