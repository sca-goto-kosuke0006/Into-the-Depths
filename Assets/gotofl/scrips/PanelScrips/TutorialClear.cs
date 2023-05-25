using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialClear : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Score scoreManager;

    public void OnClick()
    { 
        Panel.SetActive(false);
        Time.timeScale =1;

        scoreManager.ResetScore();//ここでスコアをリセット
    }
}
