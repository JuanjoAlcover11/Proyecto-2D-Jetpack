using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JA_GameManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public int Score = 0;

    public static JA_GameManager sharedInstance;

    public void contador(int p)
    {
        Score += p; // suma 1
        pointText.text = $"Score: {Score}";// puntuación
    }
}
