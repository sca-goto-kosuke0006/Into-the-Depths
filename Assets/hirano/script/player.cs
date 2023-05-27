using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]float speed;
    private string enemyTag = "Enemy";
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //右
        if (x > 0)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        //左
        if (x < 0)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        //上
        if (y > 0)
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        //下
        if (y < 0)
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == enemyTag)
        {
            Debug.Log("Damage");
        }
    }
}
