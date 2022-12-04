using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JA_DetectCollision : MonoBehaviour
{
    private JA_PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = FindObjectOfType<JA_PlayerController>();
    }
    private void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
