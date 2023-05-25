﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialYesNo : MonoBehaviour
{
    [SerializeField] GameObject Panel;

    public void OnClick()
    {
        var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
        Panel.SetActive(!isActive);
    }
}
