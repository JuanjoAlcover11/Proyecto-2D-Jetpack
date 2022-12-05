using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JA_DetectCollision : MonoBehaviour
{
    private JA_PlayerController playerControllerScript;
    private JA_GameManager GameManagerScript;
    private Animator playerAnimator;

    private void Start()
    {
        playerControllerScript = FindObjectOfType<JA_PlayerController>();
        GameManagerScript = FindObjectOfType<JA_GameManager>();
        playerAnimator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Gameover");
        }

        if (otherCollider.gameObject.CompareTag("Road"))
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }

    }
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
       if (otherCollider.gameObject.CompareTag("Coin"))
       {
            Destroy(otherCollider.gameObject);
            GameManagerScript.contador(1);
        }
    }

}
