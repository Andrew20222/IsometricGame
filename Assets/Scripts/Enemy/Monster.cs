using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : Enemy
{
    private int _direction = 1;
    private float _scaleMonsterX = -0.5f;
    private float _scaleMonsterY = 0.5f;
    [SerializeField] private GameObject monster;
    [SerializeField] private Slider hpBar;
    private void Update()
    {
        Move();
        UpdateUI();
    }
    public override void Move()
    {
        Rb.velocity = Vector3.left * Speed * _direction * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerAttack>())
        {
            TakeDamage(collision.gameObject.GetComponent<PlayerAttack>().Damage);
        }
    }

    private void UpdateUI()
    {
        hpBar.value = Health;
    }


    private void TakeDamage(int damage)
    {
        Health -= damage;
        if( Health < 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _direction = -_direction;
        var scaleX = _scaleMonsterX * _direction;
        monster.transform.localScale = new Vector3(scaleX, _scaleMonsterY);
    }
}
