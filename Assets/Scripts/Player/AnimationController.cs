using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private PlayerController player;

    private string _animationRunState = "IsRun";
    private string _animationUpState = "IsUp";
    private string _animationSideState = "IsSide";
    private float _minInputValue = 0f;
    private void Update()
    {
        SetAnimation(player.Direction);
    }
    private void SetAnimation(Vector2 direction)
    {
        if (direction.x > _minInputValue)
        {
            spriteRenderer.flipX = true;
            animator.SetBool(_animationSideState, true);
        }

        if (direction.x < _minInputValue)
        {
            spriteRenderer.flipX = false;
            animator.SetBool(_animationSideState, true);
        }

        if (direction.x == _minInputValue) animator.SetBool(_animationSideState, false);

        if (direction.y > _minInputValue)
        {
            animator.SetBool(_animationUpState, true);
        }

        else
        {
            animator.SetBool(_animationUpState, false);
        }

        if (direction.y < _minInputValue)
        {
            animator.SetBool(_animationRunState, true);
        }

        else
        {
            animator.SetBool(_animationRunState, false);
        }
    }
}