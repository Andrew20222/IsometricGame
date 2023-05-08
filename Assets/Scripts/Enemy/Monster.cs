using UnityEngine;

public class Monster : Enemy
{
    private int _direction = 1;
    private float _scaleMonsterX = -0.5f;
    private float _scaleMonsterY = 0.5f;
    [SerializeField] private GameObject monster;
   
    private void Update()
    {
        Move();
        UpdateUI();
        Die();
    }
    public override void Move()
    {
        Rb.velocity = _direction * Speed * Time.deltaTime * Vector3.left;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>())
        {
            Attack(ref collision.gameObject.GetComponent<PlayerHealth>().Health);
        }
    }

    private void UpdateUI()
    {
        HpBar.value = Health;
    }

    private void Attack(ref int Health)
    {
        Health -= Damage;
        if(Health < 0f)
        {
            CountPoint++;
            SetCountPointUI();
        }
    }

    private void Die()
    {
        if(Health < 0f)
            Destroy(gameObject);
    }

    private void SetCountPointUI()
    {
        Result.text = $"EnemyScore is {CountPoint}";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _direction = -_direction;
        var scaleX = _scaleMonsterX * _direction;
        monster.transform.localScale = new Vector3(scaleX, _scaleMonsterY);
    }
}
