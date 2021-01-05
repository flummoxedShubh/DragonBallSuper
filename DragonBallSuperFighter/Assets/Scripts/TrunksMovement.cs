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
        movement.x = Input.GetAxisRaw("Horizontal");
        
        if(movement.x != 0)
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("Horizontal", movement.x);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }


        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
