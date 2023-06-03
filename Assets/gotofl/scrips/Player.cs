using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed;

    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector3 scale = transform.localScale;
        if (x >= 0)
        {
            // 右方向に移動中
            scale.x = 1; // そのまま（右向き）
        }
        else
        {
            // 左方向に移動中
            scale.x = -1; // 反転する（左向き）
        }
        // 代入し直す
        transform.localScale = scale;
        float y = Input.GetAxisRaw("Vertical");
        //変更　スピードをかけている
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);



    }
}



