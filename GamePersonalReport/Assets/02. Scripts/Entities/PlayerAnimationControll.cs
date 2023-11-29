using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControll : MonoBehaviour
{
    private PlayerController _controller;

    private Animator _animator;

    private void Start()
    {
        _controller = GetComponent<PlayerController>();
        _animator = GetComponentInChildren<Animator>();

        _controller.OnMoveEvent += OnMovementAnimation;
    }

    private void OnMovementAnimation(Vector2 direction)
    {
        _animator.SetBool("isMove", direction.magnitude > 0f);
    }
}