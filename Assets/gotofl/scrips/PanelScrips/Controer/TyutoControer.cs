using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TyutoControer : MonoBehaviour
{
  
    [SerializeField] Button YesButton;
    [SerializeField] Button NoButton;
    [SerializeField] Button resumeButton;

    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void SELECT()
    {
        Debug.Log("Pause");
        EventSystem.current.SetSelectedGameObject(null);
        YesButton.Select();
       // if (Input.GetKeyDown("joystick button 0"))
       // {
       //     YesButton.Select();
      //      Debug.Log("test");
      //  }
    }


}
