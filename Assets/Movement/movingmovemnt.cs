using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingmovemnt : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public Animator animator;
    [SerializeField] public float Test;

    Vector2 moving;

    void Update()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        moving = new Vector2(mx, my).normalized * moveSpeed;
        rb.velocity = moving;

        animator.SetFloat("Horizontal", mx);
        animator.SetFloat("Vertical", my);
        animator.SetFloat("Speed", moving.sqrMagnitude);
    }

    private void FixedUpdate()
    {

    }

}
