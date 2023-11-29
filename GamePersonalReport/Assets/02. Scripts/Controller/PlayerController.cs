using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    Move,
    Attack
}

public class PlayerController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    public event Action<PlayerState, Vector2> OnStateChangesEvents;

    private PlayerState _currentPlayerState = PlayerState.Idle;

    private void ChangeState(PlayerState newState, Vector2 direction)
    {
        if(_currentPlayerState != newState)
        {
            _currentPlayerState = newState;
            OnStateChangesEvents?.Invoke(newState, direction);
        }
    }

    public void StateMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
            ChangeState(PlayerState.Move, direction);
        else
            ChangeState(PlayerState.Idle, direction);
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
