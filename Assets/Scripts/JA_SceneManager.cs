using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JA_SceneManager : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainscene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
