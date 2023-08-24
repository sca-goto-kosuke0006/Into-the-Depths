﻿
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackTitel : MonoBehaviour
{
    [SerializeField] GameObject Panel;
   


    public void OnClick()
    {

        var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
        Panel.SetActive(!isActive);

    }
}