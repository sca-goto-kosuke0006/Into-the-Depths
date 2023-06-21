using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector3 scale = transform.localScale;
       
        // 代入し直す
        transform.localScale = scale;
        float y = Input.GetAxisRaw("Vertical");
        //変更　スピードをかけている
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);



    }
}
