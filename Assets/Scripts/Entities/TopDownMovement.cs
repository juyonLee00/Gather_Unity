using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer spriteRenderer;

    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GameObject.Find("MainSprite").GetComponentInChildren<Animator>();
        spriteRenderer = GameObject.Find("MainSprite").GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        CheckWalking();
        CheckChangedDirection(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    private void CheckWalking()
    {
        if (_movementDirection.x != 0 || _movementDirection.y != 0)
        {
            anim.SetBool("isWalk", true);
        }

        else
        {
            anim.SetBool("isWalk", false);
        }
    }

    private void CheckChangedDirection(Vector2 direction)
    {
        if(direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
