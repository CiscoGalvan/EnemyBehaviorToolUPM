using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Credits to Mix and Jam
public class PlayerJump : MonoBehaviour
{
	private Rigidbody2D rb;
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (rb.velocity.y < 0)
		{
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		}
		else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
		{
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
	}
}
