using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{
    
    Slider HPbar;
   


    void Start()
    {
       
        //HPバーを取得
        HPbar = GameObject.Find("HPbar").GetComponent<Slider>();
   
    }
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーがぶつかった相手が酸素アイテム
        if (collision.gameObject.CompareTag("Oxygen"))
        {
            HPbar.value += 30;
        }
        //プレイヤーがぶつかった相手が異物アイテム
        if (collision.gameObject.CompareTag("Relic1"))
        {
            HPbar.value += 150;
        }
        if (collision.gameObject.CompareTag("Relic2"))
        {
            HPbar.value += 150;
        }
        if (collision.gameObject.CompareTag("Relic3"))
        {
            HPbar.value += 150;
        }
    }
}