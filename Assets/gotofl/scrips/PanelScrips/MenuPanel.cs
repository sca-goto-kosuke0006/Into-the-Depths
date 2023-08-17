using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) ||Input.GetKeyDown("joystick button 7"))
            {
            var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
            Panel.SetActive(!isActive);
            if (isActive == false) { 
                Time.timeScale = 0;
            }
            else
            {
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Time.timeScale = 1;
            }
        }
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    var isActive = Panel.activeInHierarchy; // panelがアクティブか取得
        //    Panel.SetActive(!isActive);
        //    if()
        //    {
        //        Time.timeScale = 0;
        //    }
        //    else
        //    {
        //        Time.timeScale = 1;
        //    }
        //}
    }
}
