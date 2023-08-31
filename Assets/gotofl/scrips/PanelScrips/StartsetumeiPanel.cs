using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartsetumeiPanel : MonoBehaviour
{
    [SerializeField] GameObject StartPanel;
    [SerializeField] GameObject Panel2;

    private bool Flag;
    // Start is called before the first frame update
    void Start()
    {
        Flag =false;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Flag == false)
        {
            if (Input.GetKeyDown("joystick button 0")||Input.GetKeyDown(KeyCode.Space)){
            StartPanel.SetActive(false);
            Panel2.SetActive(true);
                Flag = true; } 
        }

       else
        {
            if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.Space))
            {
             
                Panel2.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
    }
