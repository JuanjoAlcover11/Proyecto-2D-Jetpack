using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JA_GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public static JA_GameOverManager sharedInstance;

   
    void Start()
    {
        ApplyOptions();
    }

    public void ApplyOptions()
    {
        pointText.text = JA_DataPersistance.PlayerStats.currentScore.ToString();
        //We make that the score of the main scene appears in this scene
    }

}
