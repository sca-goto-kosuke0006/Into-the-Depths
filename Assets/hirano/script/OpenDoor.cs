using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    //左に向かうときに使う目的地
    [SerializeField] private GameObject leftGoalPos;
    //右に向かう時に使う目的地
    [SerializeField] private GameObject rightGoalPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //右に動く関数
    /*public void Open()
    {
        this.transform.Translate(Vector3.right*5.0f);
    }

    //左に動く関数
    public void LeftMove()
    {

    }*/
}
