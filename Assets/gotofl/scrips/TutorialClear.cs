using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialClear : MonoBehaviour
{
    [SerializeField] GameObject Panel;

    public void OnClick()
    { 
        Panel.SetActive(false);
        Time.timeScale =1;
    }
}
