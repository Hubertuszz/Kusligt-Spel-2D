using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public Vector2 lookFacing;
    public Transform ground;

    bool isGrounded = true;

    public int circleRad;
    public LayerMask whatIsGround;
    public float moveSpeed;
    public float jumpForce;
    public bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(ground.position, circleRad, whatIsGround);

        Vector3 tryMove = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            tryMove += Vector3Int.left;
            if (facingRight == true)
                Flip();
        }
        if (Input.GetKey(KeyCode.D))
        {
            tryMove += Vector3Int.right;
            if (facingRight == false)
                Flip();
        }

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //    sr.flipX = false;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        //    sr.flipX = true;
        //}


        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
            rb.velocity = Vector3.up * 1000;

        rb.velocity = Vector3.ClampMagnitude(tryMove, 1f) * moveSpeed;

        if (tryMove.magnitude > 0f)
            lookFacing = tryMove;

    }
    public void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}


