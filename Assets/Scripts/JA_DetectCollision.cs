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
    public ParticleSystem coinParticle;
    private AudioSource Audio;
    public AudioClip coinClip;

    private void Start()
    {
        playerControllerScript = FindObjectOfType<JA_PlayerController>();
        GameManagerScript = FindObjectOfType<JA_GameManager>();
        playerAnimator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter2D(Collision2D otherCollider)
    {
        //If the object is a obstacle, we lose and we start the scene "gameover"
        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            GameManagerScript.saveContador();
            SceneManager.LoadScene("JA_Gameover");
        }
        //We see when the player is touching the ground
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
        //If the object is a coin, we destroy it and we gain a point
       if (otherCollider.gameObject.CompareTag("Coin"))
       {
            Audio.PlayOneShot(coinClip, 1);
            Destroy(otherCollider.gameObject);
            GameManagerScript.contador(1);
            Instantiate(coinParticle, transform.position,
                coinParticle.transform.rotation);
            
        }
    }

}
