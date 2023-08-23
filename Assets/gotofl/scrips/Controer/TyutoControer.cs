using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TyutoControer : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] Button StartButton;
    [SerializeField] Button SkippuButton;
    [SerializeField] Button resumeButton;

    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause)
        {
            Debug.Log("Pause");
            if (Input.GetKeyDown("joystick button 0"))//加速移動
            {
                StartButton.Select();
                Debug.Log("test");
            }
        }
       
    }
}
