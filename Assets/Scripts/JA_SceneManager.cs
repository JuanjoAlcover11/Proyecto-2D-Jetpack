using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JA_SceneManager : MonoBehaviour
{
    public void Restart()
    {//Game scene
        Time.timeScale = 1f;
        SceneManager.LoadScene("JA_Mainscene");
    }
    public void MainMenu()
    {//Menu scene
        SceneManager.LoadScene("JA_Mainmenu");
    }
}
