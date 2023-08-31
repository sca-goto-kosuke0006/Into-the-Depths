using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChenz : MonoBehaviour
{
    GameObject mainCamObj;

    private float cameraX = 0.0f;

    private bool Flag;
   
    // Use this for initialization
    void Start()
    {
        mainCamObj = Camera.main.gameObject;


        Flag =false;
    }

    private void Update()
    {
        if (Flag == false)
        {
            void OnTriggerEnter2D(Collider2D collision)
            {
                
                Debug.Log("入る");
                Flag=true;
            }
        }
        else
        {
            void OnTriggerEnter2D(Collider2D collision)
            {
               
                Debug.Log("戻る");
                Flag=false;
            }
        }
    }

}
