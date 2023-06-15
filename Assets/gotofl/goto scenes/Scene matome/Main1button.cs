using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main1button : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("mainStage1");
    }
}

