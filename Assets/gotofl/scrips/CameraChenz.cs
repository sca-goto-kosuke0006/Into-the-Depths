﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChenz : MonoBehaviour
{
    public string Check { get; set;}
   
    // Use this for initialization
    void Start()
    {
        Check="";
      
    }

    private void Update()
    {
        

    }

   
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Move" || collision.name == "Move1") { 
            Check = collision.name;
        Debug.Log(collision.name);
        }

        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Move"|| collision.name == "Move1")
        {
            Check = "";
            Debug.Log("でた");
        }
       
       
    }
}
