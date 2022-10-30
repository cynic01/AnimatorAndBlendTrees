using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if (Input.GetKey(KeyCode.A)) {
            animator.SetFloat("Speed", 1);
            transform.position = (Vector2) transform.position + new Vector2(-5, 0) * Time.deltaTime;
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D)) {
            animator.SetFloat("Speed", 1);
            transform.position = (Vector2) transform.position + new Vector2(5, 0) * Time.deltaTime;
            sr.flipX = false;
        }
        else {
            animator.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetTrigger("Jump");
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
}
