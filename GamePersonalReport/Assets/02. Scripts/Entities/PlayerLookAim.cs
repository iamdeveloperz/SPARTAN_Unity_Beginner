using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAim : MonoBehaviour
{
    private SpriteRenderer _playerRenderer;

    private PlayerController _controller;

    private void Start()
    {
        _controller = GetComponent<PlayerController>();
        _playerRenderer = GetComponentInChildren<SpriteRenderer>();

        // 이벤트 구독
        _controller.OnLookEvent += OnAim;
    }

    #region Main Methods
    public void OnAim(Vector2 aimDirection)
    {
        RotatePlayer(aimDirection);
    }

    private void RotatePlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
    #endregion
}