using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Score: MonoBehaviour
{
    public Text Scoretext;
    public Text Scorejewelry;
    public Text Scoremineral;
    private int score =0;
    private int scorejewelry =0;
    private int scoremineral =0;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーがぶつかった相手が宝石アイテム
        if (collision.gameObject.CompareTag("Jewelry"))
        {
            score+=100;
            Scoretext.text=string.Format("Score:{0:00000}",score);
            scorejewelry +=1;
            Scorejewelry.text= string.Format("宝石:{0:00}", scorejewelry);

        }
        //プレイヤーがぶつかった相手が鉱石アイテム
        if (collision.gameObject.CompareTag("Mineral"))
        {
            score += 50;
            Scoretext.text = string.Format("Score:{0:00000}", score);
            scoremineral+=1;
            Scoremineral.text =string.Format("鉱石:{0:00}", scoremineral);
        }

    }
}