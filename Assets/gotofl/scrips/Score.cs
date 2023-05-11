using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Score: MonoBehaviour
{
    public Text Scoretext;
    private int score =0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーがぶつかった相手が宝石アイテム
        if (collision.gameObject.CompareTag("Jewelry"))
        {
            score+=100;
            Scoretext.text=string.Format("Score:{0:00000}",score);
        }
        //プレイヤーがぶつかった相手が鉱石アイテム
        if (collision.gameObject.CompareTag("Mineral"))
        {
            score += 50;
            Scoretext.text = string.Format("Score:{0:00000}", score);
        }

    }

    void Start()
    {
       
    }
    void Update()
    {
    
    }
}