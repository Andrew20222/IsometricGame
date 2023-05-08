using TMPro;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private TMP_Text result;
    [SerializeField] private PlayerHealth health;
    private int _countPoint = 0;
    public int CountPoint { get { return _countPoint; } set { _countPoint = value; } }

    private void Start()
    {
        _countPoint = 0;
    }
    private void Update()
    {
        Die();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Monster>())
        {
            Attack(ref collision.gameObject.GetComponent<Monster>().Health);
        }
    }

    private void Attack(ref int Health)
    {
        Health -= damage;
        if(Health < 0f)
        {
            _countPoint++;
            SetCountPointUI();
        }
    }

    private void Die()
    {
        if(health.Health < 0f)
        {
            Destroy(gameObject);
        }
    }

    private void SetCountPointUI()
    {
        result.text = $"PlayerScore is {_countPoint}";
    }
}
