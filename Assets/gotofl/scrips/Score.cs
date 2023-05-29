using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Score: MonoBehaviour
{
    [SerializeField]private Text scoreText;
    [SerializeField]private Text scoreJewelry;
    [SerializeField] private Text scoreMineral;

    [SerializeField] private Text totalScore;
    [SerializeField] private Text totalJewelry;
    [SerializeField] private Text totalMineral;



    private int totalscore =0;
    private int scorejewelry =0;
    private int totalJLscore=0;
    private int scoremineral =0;
    private int totalMLscore=0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーがぶつかった相手が宝石アイテム
        if (collision.gameObject.CompareTag("Jewelry"))
        {
            //宝石と鉱石の合計値
            totalscore+=100;
            scoreText.text=string.Format("Score:{0:00000}",totalscore);
            //宝石の取得数
            scorejewelry +=1;
            scoreJewelry.text= string.Format("宝石:{0:00}", scorejewelry);

            //クリア時の宝石スコア合計
            totalJLscore +=100;
            totalJewelry.text = string.Format("宝石:{0:00}", totalJLscore);
            //クリア時の宝石と鉱石の合計値
            totalScore.text = string.Format("合計Score:{0:00}", totalscore);


        }
        //プレイヤーがぶつかった相手が鉱石アイテム
        if (collision.gameObject.CompareTag("Mineral"))
        {
            //宝石と鉱石の合計値
            totalscore += 50;
            scoreText.text = string.Format("Score:{0:00000}", totalscore);
            //鉱石の取得数
            scoremineral += 1;
            scoreMineral.text =string.Format("鉱石:{0:00}", scoremineral);

            //クリア時の鉱石スコア合計
            totalMLscore += 50;
            totalMineral.text = string.Format("鉱石:{0:00}", totalMLscore);
            //クリア時の宝石と鉱石の合計値
            totalScore.text = string.Format("合計Score:{0:00}", totalscore);
        }

    }
    public void ResetScore()
    {
        //0にするプログラム
        totalscore=0;
        scoreText.text = string.Format("Score:{0:00000}", totalscore);
        scorejewelry = 0;
        scoreJewelry.text = string.Format("宝石:{0:00}", scorejewelry);
        scoremineral = 0;
        scoreMineral.text = string.Format("鉱石:{0:00}", scoremineral);
        totalJLscore = 0;
        totalJewelry.text = string.Format("宝石:{0:00}", totalJLscore);
        totalMLscore = 0;
        totalMineral.text = string.Format("鉱石:{0:00}", totalMLscore);
    }
}