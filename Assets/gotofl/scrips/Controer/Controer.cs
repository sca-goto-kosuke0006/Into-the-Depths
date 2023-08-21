using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controer : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] Button ruleButton;
    [SerializeField] Button resumeButton;
    [SerializeField] Button titleButton;
    bool isPause = false;
    // Update is called once per frame
    void Update()
    {
        Debug.Log("あたった");
        if (isPause)
        {
            Debug.Log("Pause");
            if (Input.GetKeyDown("joystick button 0"))//加速移動
            {
                ruleButton.Select();
                Debug.Log("test");
            }
        }

        if (Input.GetKeyDown("joystick button 0"))//加速移動
        {
            Debug.Log("button0");
        }
        if (Input.GetKeyDown("joystick button 1"))//おす、引く
        {
            Debug.Log("button1");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKeyDown("joystick button 3"))//ピッケル
        {
            Debug.Log("button3");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))//ポーズ
        {
            var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
            Panel.SetActive(!isActive);
            isPause = true;
            ruleButton.Select();
            if (Input.GetKeyDown("joystick button 1"))//おす、引く
            {
               //Select;
            }
            if (isActive == false)
            {
                Time.timeScale = 0;
            }
            else
            {
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Time.timeScale = 1;
                isPause = false;
                Debug.Log("button7");
            }
            if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if ((hori != 0) || (vert != 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
        }
    }
} }