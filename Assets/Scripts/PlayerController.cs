using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string horizontal_name = "Horizontal";
    private const string vertical_name = "Vertical";
   
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed = 5f;

    private Vector2 _direction;
    private string _animationRunState = "IsRun";
    private string _animationUpState = "IsUp";
    private string _animationSideState = "IsSide";
    private float _minInputValue = 0f;

    private void Update()
    {
        _direction.x = Input.GetAxis(horizontal_name);
        _direction.y = Input.GetAxis(vertical_name);

        SetAnimation();
        Move();
    }
    private void Move()
    {
        rb.MovePosition(rb.position + _direction * speed * Time.deltaTime);
    }   
    
    private void SetAnimation()
    {
        if(_direction.x > _minInputValue)
        {
            spriteRenderer.flipX = true;
            animator.SetBool(_animationSideState, true);
        }

        if (_direction.x < _minInputValue)
        {
            spriteRenderer.flipX = false;
            animator.SetBool(_animationSideState, true);
        }

        if(_direction.x == _minInputValue) animator.SetBool(_animationSideState, false);

        if (_direction.y > _minInputValue)
        {
            animator.SetBool(_animationUpState, true);
        }

        else
        {
            animator.SetBool(_animationUpState, false);
        }

        if (_direction.y < _minInputValue)
        {
            animator.SetBool(_animationRunState, true);
        }

        else
        {
            animator.SetBool(_animationRunState, false);
        }
    }
}
