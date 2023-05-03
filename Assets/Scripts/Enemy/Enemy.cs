using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float Speed;
    [SerializeField] protected Rigidbody2D Rb;
    public abstract void Move();
}
