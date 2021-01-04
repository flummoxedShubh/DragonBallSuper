using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunksMovement : MonoBehaviour
{
    public float speed = 10f;
    
    private Rigidbody2D rb;
    private Animator anim;

    private Vector2 movement; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        anim.SetFloat("Horizontal", movement.x);

        rb.MovePosition(new Vector2(movement.x * speed * Time.fixedDeltaTime, rb.position.y));
    }
}
