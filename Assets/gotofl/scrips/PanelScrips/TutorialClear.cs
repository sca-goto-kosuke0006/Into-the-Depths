using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialClear : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Score scoreManager;

    public void OnClick()
    { 
        Panel.SetActive(false);
        Time.timeScale =1;
        SceneManager.LoadScene("MainStage1");

        scoreManager.ResetScore();//ここでスコアをリセット
    }
}
