using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private float _playerSpeed = 5f;

    private void Start()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();

        // 이벤트 구독
        _controller.OnMoveEvent += Movement;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    #region Main Methods
    private void Movement(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        Vector2 velocity = direction * _playerSpeed;

        _rigidbody.velocity = velocity;
    }
    #endregion

}