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
        UpdateHealthBar();
    }
    private void UpdateHealthBar()
    {
        hpBar.value = Health;
    }
}
