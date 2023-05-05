using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerHealth))]
public class PlayerController : MonoBehaviour
{
    private const string horizontal_name = "Horizontal";
    private const string vertical_name = "Vertical";

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private PlayerHealth health;
    private Vector2 _direction;
    public Vector2 Direction { get { return _direction; } set { _direction = value; } }
    

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