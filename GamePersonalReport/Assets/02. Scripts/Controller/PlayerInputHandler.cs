using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : PlayerController
{
    private Camera _mainCamera;

    private Vector2 _lastMouseWorldPos = Vector2.zero;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    #region Action
    public void OnMovement(InputValue inputValue)
    {
        Vector2 moveInput = inputValue.Get<Vector2>().normalized;
        StateMove(moveInput);
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 mousePos = inputValue.Get<Vector2>();

        // ��ũ�� ��ǥ�� ���� ��ǥ�� ��ȯ ����� �Ѵ�.
        _lastMouseWorldPos = _mainCamera.ScreenToWorldPoint(mousePos);

        this.MovementAndLookCalculate();
    }

    public void OnFire(InputValue inputValue)
    {

    }

    #endregion

    private void MovementAndLookCalculate()
    {
        // ���� ��ǥ���� ĳ���� ��ǥ�� ���� ���콺 ����(����� �Ÿ�)�� ���´�.
        // ���⼭ ����ȭ�� ���־� ���⸸�� �����´�.
        Vector2 mouseDirection = (_lastMouseWorldPos - (Vector2)transform.position).normalized;

        if (mouseDirection.magnitude > 0.9f)
            CallLookEvent(mouseDirection);
    }
}
