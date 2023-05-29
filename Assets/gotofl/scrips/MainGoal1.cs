using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGoal1 : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    private bool _isMain1Goal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!_isMain1Goal)
        {
            if (other.gameObject.tag == "Player")
            {
                Panel.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("ゴールした");
                _isMain1Goal = true;
            }
        }
    }

}

