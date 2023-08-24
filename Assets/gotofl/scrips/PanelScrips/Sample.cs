using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField]
    Button b,b1,b2,b3,b4;
    [SerializeField] GameObject Panel;
    public BackTitel backTitel;

    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        
        //スタート
        if(vert > 0 && !check)
        {
            b.Select();
        }
        
        if(vert > 0 && check)
        {
            b2.Select();
        }

        //オプション
        if (vert < 0 && !check)
        {
            b1.Select();
        }

        if (vert < 0 && check)
        {
            b3.Select();
        }
        if (vert < 0 && check &&b3)
        {
            b4.Select();
        }
        Debug.Log(vert);

        //戻る
        if(backTitel)
        {
            var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
            Panel.SetActive(!isActive);

        }
    }

    public void TutorialScreen()
    {
        check = true;
    }
    public void BackScreen()
    {
        check = false;
    }
    public void OptionScreen()
    {
        check = false;
    }
   
}
