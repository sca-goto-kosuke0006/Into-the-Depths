using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform playerTr; // プレイヤーのTransform
    [SerializeField] Vector2 camaraMaxPos = new Vector2(0, 0); // カメラの右上限界点
    [SerializeField] Vector2 camaraMinPos = new Vector2(0, 0); // カメラの左下限界点

    private void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(playerTr.position.x+6, camaraMinPos.x, camaraMaxPos.x), // カメラの左右を制限
            Mathf.Clamp(playerTr.position.y, camaraMinPos.y, camaraMaxPos.y), // カメラの上下を制限
            -10f); // カメラz座標は-10f
    }
}
