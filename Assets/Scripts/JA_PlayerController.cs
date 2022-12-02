using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class JA_PlayerController : MonoBehaviour
{
	Rigidbody2D body;

	public bool gameOver = false;

	private float upRange = 4.3f;
	private float downRange = -4.15f;

	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		
		if (Input.GetMouseButton(0))
		{
			body.AddForce(new Vector3(0, 50, 0), ForceMode2D.Force);
		}
        else
        {
			body.AddForce(new Vector3(0, -10, 0), ForceMode2D.Force);
		}
	}

    private void Update()
    {
		if (transform.position.y < downRange)
		{
			transform.position = new Vector3(transform.position.x, downRange,
				transform.position.z);
			body.AddForce(new Vector3(0, 20, 0), ForceMode2D.Force);

		}

		if (transform.position.y > upRange)
		{
			transform.position = new Vector3(transform.position.x, upRange,
				transform.position.z);
			body.AddForce(new Vector3(0, -40, 0), ForceMode2D.Force);
		}
	}


}
