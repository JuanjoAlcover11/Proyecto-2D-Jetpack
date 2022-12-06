using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JA_DestroyOutOfBounds : MonoBehaviour
{
    private float xLim = -25f;

    void Update()
    {//The objects get destroyed if they are out of the screen
        if (transform.position.x < xLim)
        {
            Destroy(gameObject);
        }
    }
}
