using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float Speed;
    [SerializeField] protected Rigidbody2D Rb;
    [SerializeField] public int Health;
    [SerializeField] protected int Damage;
    [SerializeField] protected Slider HpBar;
    [SerializeField] protected TMP_Text Result;
    [SerializeField] public int CountPoint = 0;
    public abstract void Move();
}
