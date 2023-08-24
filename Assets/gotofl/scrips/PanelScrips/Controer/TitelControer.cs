using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TitelControer : MonoBehaviour
{
    [SerializeField] Button StartButton;
    [SerializeField] Button resumeButton;
    [SerializeField] Button titleButton;

    [SerializeField]
    private GameObject statusWindow;
    [SerializeField]
    private ActivateButton select1;
    [SerializeField]
    private ActivateButton select2;
    // Start is called before the first frame update
    void Start()
    {

        //StartButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))//加速移動
        {
            StartButton.Select();
            Debug.Log("test"); }
            /* //　画面を開いた時にBackground1のボタンのインタラクティブをtrue、Background2のボタンのインタラクティブをfalseにする
             if (statusWindow.activeSelf)
             {

                 select1.ActivateOrNotActivate(true);
                 select2.ActivateOrNotActivate(false);
                 //　画面を閉じたら選択を解除
             }
             else
             {
                 EventSystem.current.SetSelectedGameObject(null);
             }*/
        }
    }
