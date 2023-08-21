using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TitelControer : MonoBehaviour
{
    [SerializeField] Button StartButton;
    [SerializeField] Button resumeButton;
    [SerializeField] Button titleButton;
    // Start is called before the first frame update
    void Start()
    {

        StartButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
