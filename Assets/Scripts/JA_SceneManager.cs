using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JA_SceneManager : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Mainscene");
    }
}