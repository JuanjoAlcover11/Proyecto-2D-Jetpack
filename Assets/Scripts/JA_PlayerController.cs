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


	private Animator playerAnimator;

	void Start()
	{
		body = GetComponent<Rigidbody2D>();
		playerAnimator = GetComponent<Animator>();
	}

	private void FixedUpdate()
	{
		//When we click, the player goes up
		if (Input.GetMouseButton(0))
		{
			body.AddForce(new Vector3(0, 50, 0), ForceMode2D.Force);
			playerAnimator.SetBool("isWalking", false);
			playerAnimator.SetBool("Jetpack", true);
		}
        else
        {//If we don't, it goes down
			body.AddForce(new Vector3(0, -10, 0), ForceMode2D.Force);
			playerAnimator.SetBool("Jetpack", false);
		}
	}

    private void Update()
    {//Screen limits
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
