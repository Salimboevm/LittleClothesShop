﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private Animator anim;
    [SerializeField]
    float speed = 2f;
    bool moving = false;
    Vector2 motion;
    private float horizontal;
    private float vertical;

    public Vector2 Motion { get => motion;private set => motion = value; }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Motion = new Vector2(horizontal , vertical);
        anim.SetFloat("vertical", Input.GetAxisRaw("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
        moving = horizontal != 0 || vertical != 0; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rb2d.velocity = Motion * speed;
        anim.SetBool("moving", moving);
    }
}
