using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleYesNo : MonoBehaviour
{
    [SerializeField] GameObject Panel;

    public void OnClick()
    {
        var isActive = Panel.activeInHierarchy; // Panelがアクティブか取得
        Panel.SetActive(!isActive);


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
