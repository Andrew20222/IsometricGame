using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health;

    [SerializeField] private Slider hpBar;

    private void Update()
    {
        UpdateUI();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if(Health < 0f)
        {
            Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Monster>())
        {
            TakeDamage(collision.gameObject.GetComponent<Monster>().Damage);
        }
    }

    private void UpdateUI()
    {
        hpBar.value = Health;
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
