using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject PanelGoal;
    private bool _is1Goal;

    private void Start()
    {
        _is1Goal = true;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("kao");
        if (_is1Goal==true) { 
            if (other.gameObject.tag == "Player")
        {
                Panel.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("第一階層クリア");
               
               
            }
       }
      
    }
    public　void OnClick1()
    {
        PanelGoal.SetActive(true);
        Panel.SetActive(false);
        _is1Goal = false;

    }
    public　void OnClick2()
    {
        Panel.SetActive(false);
        
        Time.timeScale = 1;

    }

}
