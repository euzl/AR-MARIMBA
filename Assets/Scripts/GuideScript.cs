using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class GuideScript : MonoBehaviour
{
    private TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("GuideText").GetComponent<TextMesh>();

        // display text
        text.text = "제공된 종이를 준비했다면\n손 또는 도구를 이용하여\n실로폰처럼 연주할 수 있습니다!";
        
        // functino call in 3 sec
        Invoke("SetTextStart", 3);
        
        // Destroy the game object in 2 sec
        Destroy(text, 5); 
    }

    void SetTextStart()
    {
        text.text = "이제 시작합니다!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
