using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] SpriteRenderer sr;
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x < 0) sr.flipX = true;
        else sr.flipX = false;
        Vector3 scale = transform.localScale;

        // 代入し直す
        transform.localScale = scale;
        float y = Input.GetAxisRaw("Vertical");
        //変更　スピードをかけている
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.S))
        {
            //Destroy(gameObject);

        }

    }
}
