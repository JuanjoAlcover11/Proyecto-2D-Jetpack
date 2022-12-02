using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JA_DestroyOutOfBounds : MonoBehaviour
{
    private float xLim = -25f;

    void Update()
    {
        if (transform.position.x < xLim)
        {
            Destroy(gameObject);
        }
    }
}
