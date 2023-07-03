using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    [SerializeField] private GameObject rightMove;
    [SerializeField] private GameObject leftMove;
    private int moveCounter = 0;
    private bool finishMoved = false;//ギミックの動作が終了されたらtrue
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("iwa"))
        {
            StartMove();
            Debug.Log("うごいた");
        }
    }
    private void StartMove()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        //動作終了を表すbool型の変数がfalseの間だけ動かす
        while(finishMoved != true)
        {
            rightMove.transform.Translate(1.0f, 0, 0);//右方向
            leftMove.transform.Translate(-1.0f, 0, 0);//左方向
            moveCounter++;
            yield return new WaitForSeconds(0.05f);
            //目的地に着いたら
            if(moveCounter >= 5)
            {
                finishMoved = true;
                break;
            }
        }
        yield break;
    }
}
