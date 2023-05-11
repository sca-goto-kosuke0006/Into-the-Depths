using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float x_val;
    private float speed;
    public float inputSpeed;
    Slider HPbar;
   


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        //HPバーを取得
        HPbar = GameObject.Find("HPbar").GetComponent<Slider>();
   
    }
    void Update()
    {
        x_val = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        //待機
        if (x_val == 0)
        {
            speed = 0;
        }
        //右に移動
        else if (x_val > 0)
        {
            speed = inputSpeed;
        }
        //左に移動
        else if (x_val < 0)
        {
            speed = inputSpeed * -1;
        }
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーがぶつかった相手が酸素アイテム
        if (collision.gameObject.CompareTag("Oxygen"))
        {
            HPbar.value += 30;
        }
       
    }
}