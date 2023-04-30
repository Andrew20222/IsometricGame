using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string horizontal_name = "Horizontal";
    private const string vertical_name = "Vertical";
   
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private Vector2 _direction;
    private string _animationRunState = "IsRun";
    private float _minInputValue = 0f;

    private void Update()
    {
        _direction.x = Input.GetAxis(horizontal_name);
        _direction.y = Input.GetAxis(vertical_name);

        if (_direction.y > _minInputValue || _direction.x > _minInputValue || _direction.y < _minInputValue || _direction.x < _minInputValue)
        {
            animator.SetBool(_animationRunState, true);
        }

        else
        {
            animator.SetBool(_animationRunState, false);
        }

        Move();
    }
    private void Move()
    {
        rb.MovePosition(rb.position + _direction * speed * Time.deltaTime);
    }    
}
