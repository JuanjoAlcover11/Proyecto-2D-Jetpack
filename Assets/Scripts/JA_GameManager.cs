using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JA_GameManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public int Score = 0;

    public static JA_GameManager sharedInstance;

    private void Awake()
    {

        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            //If the instance already exists, we destroy it
            Destroy(this);
        }
    }

    public void contador(int p)
    {
        Score += p; //Adds 1 point to the score
        pointText.text = $"Score: {Score}";
    }

    public void saveContador()
    {
        JA_DataPersistance.PlayerStats.currentScore = Score;//When you die, we save your score
    }
}
