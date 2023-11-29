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

        // 스크린 좌표를 월드 좌표로 변환 해줘야 한다.
        _lastMouseWorldPos = _mainCamera.ScreenToWorldPoint(mousePos);

        this.MovementAndLookCalculate();
    }

    public void OnFire(InputValue inputValue)
    {

    }

    #endregion

    private void MovementAndLookCalculate()
    {
        // 월드 좌표에서 캐릭터 좌표를 빼면 마우스 벡터(방향과 거리)가 나온다.
        // 여기서 정규화를 해주어 방향만을 가져온다.
        Vector2 mouseDirection = (_lastMouseWorldPos - (Vector2)transform.position).normalized;

        if (mouseDirection.magnitude > 0.9f)
            CallLookEvent(mouseDirection);
    }
}
