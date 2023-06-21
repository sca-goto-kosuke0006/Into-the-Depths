using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    GameObject playerObj;
    Player player;
    Transform playerTransform;

    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<Player>();
        playerTransform = playerObj.transform;
    }

    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {

        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
    }
}
