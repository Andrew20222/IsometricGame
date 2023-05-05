using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Enemy
{
    private int _direction = 1;
    private float _scaleMonsterX = -0.5f;
    private float _scaleMonsterY = -0.5f;
    [SerializeField] private GameObject monster;
    private void Update()
    {
        Move();
    }
    public override void Move()
    {
        Rb.velocity = Vector3.left * Speed * _direction * Time.deltaTime;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _direction = -_direction;
        var scaleX = _scaleMonsterX * _direction;
        monster.transform.localScale = new Vector3(scaleX, _scaleMonsterY);
    }
}
