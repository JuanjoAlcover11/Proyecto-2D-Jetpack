using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D body;

	public bool gameOver = false;

	private float upRange = 4.3f;
	private float downRange = -4.15f;

	// Use this for initialization
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
		else if (Input.GetMouseButtonUp(0))
		{
			body.velocity *= 0.25f;
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
