using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public bool m_FacingRight = true;
	public float speed;
	public float jumpForce;
	public float circleRad;
	public LayerMask whatIsGround;
	public Transform feetPos;
	public bool isGrounded;

	private Rigidbody2D rb;
	private Transform player;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		player = GetComponent<Transform>();
	}

	void Update() {
		isGrounded = Physics2D.OverlapCircle(feetPos.position, circleRad, whatIsGround);

		if(isGrounded == true && Input.GetKeyDown(KeyCode.W))
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
	}

	void FixedUpdate() {
		Move(Input.GetAxisRaw("Horizontal"));
	}

	public void Move(float horiz) {
		Vector2 moveVel = rb.velocity;
		moveVel.x = horiz * speed;
		rb.velocity = moveVel;
		if (horiz > 0 && !m_FacingRight)
			Flip();
		else if (horiz < 0 && m_FacingRight)
			Flip();
	}

	public void Flip() {
        m_FacingRight = !m_FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
