using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JA_MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    private JA_PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = FindObjectOfType<JA_PlayerController>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
