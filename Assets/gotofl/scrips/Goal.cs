using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    private bool _is1Goal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!_is1Goal) { 
            if (other.gameObject.tag == "Player")
        {
                Panel.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("第一階層クリア");
                _is1Goal =true;
               
            }
       }
    }

}
