using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mouvement : MonoBehaviour
{
    public float groundCheckRadius;
    public LayerMask solLayer;
    public Transform groundCheck;
    private bool isGrounded;
    public float vitesse;
    public float forceSaut;
    public Rigidbody2D rb;
    private Vector2 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, solLayer);
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector2(0, forceSaut));
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float MouvementHori = Input.GetAxis("Horizontal") * vitesse;
        MovePlayerHori(MouvementHori);
        FacingDirection();
    }
    void MovePlayerHori(float MouvementHori)
    {
        Vector2 targetvelocity = new(MouvementHori, rb.velocity.y);
        rb.velocity = Vector2.SmoothDamp(targetvelocity, rb.velocity, ref velocity, 0.05f);

    }
    void FacingDirection()
    {
        if (rb.velocity.x > 0.1)
        {
            transform.localScale = new Vector3(Convert.ToSingle(-0.6), Convert.ToSingle(0.6), Convert.ToSingle(0.6));
        }
        if (rb.velocity.x < -0.1)
        {
            transform.localScale = new Vector3(Convert.ToSingle(0.6), Convert.ToSingle(0.6), Convert.ToSingle(0.6));
        }
    }
}
