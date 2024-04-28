using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{ 
    private Rigidbody2D rb2d;
    private float speed = 8f;
    private float jumpPower =20f;
    private float input;
    private bool checkSide = true;
    private bool ground = false;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask layerGround;

    void Flip()
    {
        if (checkSide && input < 0f || !checkSide && input > 0f)
        {
            checkSide = !checkSide;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void Input()
    {
        input = UnityEngine.Input.GetAxisRaw("Horizontal");
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      Input();
      Flip();
      Jump();
      Checkground();
    }

    bool Checkground()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.2f,layerGround);
    }

    void Jump()
    {
        if (UnityEngine.Input.GetButtonDown("Jump")&& Checkground())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,jumpPower);
        }

        if (UnityEngine.Input.GetButtonDown("Jump") && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,rb2d.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(input * speed, rb2d.velocity.y);
    }
}
