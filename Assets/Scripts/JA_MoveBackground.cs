using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JA_MoveBackground : MonoBehaviour
{
    private float repeateWidth;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        repeateWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    void Update()
    {
        if (transform.position.x < startPosition.x - repeateWidth)
        {
            transform.position = startPosition;
        }
    }
}
