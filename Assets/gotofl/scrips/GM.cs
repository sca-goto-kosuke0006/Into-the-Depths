using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    //Sliderコーポネントを管理する用
    Slider HPbar;
    //HPを定義
    public int HP = 75;

    //現在の時間
    private float currentTime = 0f;

    //自動回復と毒状態のフラグ
    public bool heal_flag = false;
    public bool poison_flag = true;

    // Start is called before the first frame update
    void Start()
    {
        //HPバーを取得
        HPbar = GameObject.Find("HPbar").GetComponent<Slider>();
        //HPバーの最大値をHPにする
        HPbar.maxValue = HP;

        //HPの初期値を０に
        HPbar.value = 75;
    }

    // Update is called once per frame
    void Update()
    {
        //前のフレームから経過した秒数を加算
        currentTime += Time.deltaTime;

        //毎秒処理を行う
        if (currentTime >= 1.0f)
        {
            //フラグがtrueの時だけ処理する
            if (heal_flag == true)
            {
                HPbar.value += 10;
            }
            if (poison_flag == true)
            {
                HPbar.value -= 1;
            }
            currentTime = 0;
        }
    }

    //ボタンで呼び出される関数
    public void heal()
    {
        poison_flag = false;
        heal_flag = true;
    }

    //ボタンで呼び出される関数
    public void poison()
    {
        heal_flag = false;
        poison_flag = true;
    }
}