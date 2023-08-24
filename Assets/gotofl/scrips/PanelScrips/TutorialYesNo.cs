using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using   UnityEngine.EventSystems;


public class TutorialYesNo : MonoBehaviour
{
   
    [SerializeField] GameObject Panel;

    public void OnClick()
    {
        var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
        Panel.SetActive(!isActive);
        EventSystem.current.SetSelectedGameObject(null);


    }
}
