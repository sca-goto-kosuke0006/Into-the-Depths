using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    private bool _isGoal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!_isGoal) { 
            if (other.gameObject.tag == "Player")
        {
                Panel.SetActive(true);
                Time.timeScale = 0;

                _isGoal =true;
            }
       }
    }
}
