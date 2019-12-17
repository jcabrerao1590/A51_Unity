using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;
	private Animator animator;
	private Rigidbody2D rigidbody2D;

	public float speed = 1f;
	public float impulseJump = 2f;
	// Start is called before the first frame update
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
		rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{


		//Debug.Log(Input.GetAxis("Horizontal"));
		//Debug.Log(Input.GetAxisRaw("Horizontal"));
		float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
		transform.Translate(Vector3.right * h * speed);
		//var player = GameObject.Find("player");
		animator.SetBool("walk", h != 0);
		if (h > 0)
		{
			spriteRenderer.flipX = false;
		}
		else if (h < 0)
		{
			spriteRenderer.flipX = true;
		}
	}

	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody2D.AddForce(Vector2.up * impulseJump, ForceMode2D.Impulse);
		}
	}
}
