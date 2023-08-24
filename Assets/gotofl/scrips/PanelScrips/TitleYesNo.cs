using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class TitleYesNo : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Button YesButton;

    public TyutoControer tCon;

    public void OnClick()
    {
        EventSystem.current.SetSelectedGameObject(null);
        var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
        Panel.SetActive(!isActive);




        YesButton.Select();
        
        Debug.Log("tt");
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
