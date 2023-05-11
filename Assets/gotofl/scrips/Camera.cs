using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {;
        // ゲームスタート時でのPlayerとカメラの位置関係を記憶
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
    }

    void LateUpdate()
    {
        // Playerの現在位置から新しいカメラの位置を作成
        Vector3 vector = player.transform.position + offset;
        // 縦方向は固定
       // vector.y = transform.position.y;
        // カメラの位置を移動
        transform.position = vector;
    }
}