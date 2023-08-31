using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGoal1 : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject PanelGoal;
    private bool _isMain1Goal;

    private void Start()
    {
        _isMain1Goal = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (_isMain1Goal==true)
        {
            if (other.gameObject.tag == "Player")
            {
                Panel.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("ゴールした");
                
            }
        }
    }
    public void OnClick1()
    {
        PanelGoal.SetActive(true);
        Panel.SetActive(false);
        _isMain1Goal = false;

    }
    public void OnClick2()
    {
        Panel.SetActive(false);

        Time.timeScale = 1;

    }

}

