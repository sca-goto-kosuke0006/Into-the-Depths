using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
            Panel.SetActive(!isActive);
            if (isActive == false) { 
                Time.timeScale = 0;
            }
            else
            {
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
