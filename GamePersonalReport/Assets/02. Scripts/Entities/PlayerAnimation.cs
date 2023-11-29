using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerController _controller;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _controller = GetComponent<PlayerController>();

        _controller.OnStateChangesEvents += HandleStateChange;
    }

    private void HandleStateChange(PlayerState state, Vector2 direction)
    {
        switch(state)
        {
            case PlayerState.Idle:
                _animator.SetBool("isMove", false);
                break;
            case PlayerState.Move:
                _animator.SetBool("isMove", true);
                break;
            case PlayerState.Attack:
                break;
        }
    }
}