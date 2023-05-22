using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hakai: MonoBehaviour
{
    List<GameObject>myParts=new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {

            // ビルパーツに Rigidbody2D を追加して Kinematic にしておく
            child.gameObject.AddComponent<Rigidbody2D>();
            child.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;

            // 子要素リストにパーツを追加
            myParts.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Explode();
        }
    }
    void Explode()
    {

        // 各パーツをふっとばす
        foreach (GameObject obj in myParts)
        {

            // 飛ばすパワーと回転をランダムに設定
            Vector2 forcePower = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
            float torquePower = Random.Range(-10, 10);

            // パーツをふっとばす！
            obj.GetComponent<Rigidbody2D>().isKinematic = false;
            obj.GetComponent<Rigidbody2D>().AddForce(forcePower, ForceMode2D.Impulse);
            obj.GetComponent<Rigidbody2D>().AddTorque(torquePower, ForceMode2D.Impulse);
        }
    }
}
