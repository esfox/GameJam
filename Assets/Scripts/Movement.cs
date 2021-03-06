﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerStatus
{
    walk,    
    interact,    
    idle,
    attack
}

public class Movement : MonoBehaviour {

    public Transform[] AttackRangeLoc;
    public Transform AttackRange;
    //private Vector2 AttackRangeDef;

    public PlayerStatus currentStatus;
    public float speed;
    //public FloatValue currentHealth;
    private Rigidbody2D rb;
    private Vector3 change;
    Animator anim;
    //public Signal playerHealthSignal;
    //public AudioManager soundFX;

    // Use this for initialization
    void Start() {
        currentStatus = PlayerStatus.walk;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        //AttackRangeDef = AttackRange.position;
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(currentStatus == PlayerStatus.interact && currentStatus == PlayerStatus.attack)
        {

        } else
        {
            UpdateAnimationAndMove();
        }
        AttackRangeFlipper();
    }
       
    void MoveCharacter()
    {            
        change.Normalize();
        rb.MovePosition(transform.position + change * speed * Time.deltaTime);        
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("isMoving", true);
            currentStatus = PlayerStatus.walk;
        }
        else
        {
            anim.SetBool("isMoving", false);
            currentStatus = PlayerStatus.idle;
        }
    }

    void AttackRangeFlipper()
    {
        if (change.x == 1)
        {
            AttackRange.position = AttackRangeLoc[0].position;
        } else if (change.x == -1) {
            AttackRange.position = AttackRangeLoc[1].position;
        } else if (change.y == 1)
        {
            AttackRange.position = AttackRangeLoc[2].position;
        }
        else if (change.y ==-1)
        {
            AttackRange.position = AttackRangeLoc[3].position;
        }
       
    }







}

