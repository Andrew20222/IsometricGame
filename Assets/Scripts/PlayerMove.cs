using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private const string horizontal_name = "Horizontal";
    private const string vertical_name = "Vertical";
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 _direction;

    private void Update()
    {
        _direction.x = Input.GetAxis(horizontal_name);
        _direction.y = Input.GetAxis(vertical_name);
        Move();
    }
    private void Move()
    {
        rb.MovePosition(rb.position + _direction * speed * Time.deltaTime);
    }    
}
