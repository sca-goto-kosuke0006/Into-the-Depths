
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SpriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    [SerializeField ] Sprite sprite;


    // Use this for initialization
    void Start()
    {

    }

   
    
    private void OnTriggerEnter2D(Collider2D collision)
    { 
       
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = sprite;

            Debug.Log("異物取った");
        }
    }
}