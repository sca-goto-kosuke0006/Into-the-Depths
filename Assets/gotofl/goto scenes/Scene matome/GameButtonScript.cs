using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonScript : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("game");
        Time.timeScale = 1;
    }
}
