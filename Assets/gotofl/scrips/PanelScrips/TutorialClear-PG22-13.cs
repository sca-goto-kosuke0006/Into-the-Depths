using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialClear : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject CanvasPanel;
    [SerializeField] Score scoreManager;

    public void OnClick()
    { 
        Panel.SetActive(false);
        CanvasPanel.SetActive(false);
        Time.timeScale =1;
        scoreManager.ResetScore();//ここでスコアをリセット
        SceneManager.LoadScene("MainStage1");

     
    }
}
