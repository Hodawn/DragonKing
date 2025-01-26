using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform
    public Vector2 minBounds; // 맵의 최소 좌표
    public Vector2 maxBounds; // 맵의 최대 좌표
    public float smoothSpeed = 0.125f; // 카메라 이동 속도

    private Vector3 offset; // 카메라와 플레이어 간의 거리

    void Start()
    {
        // 플레이어와 카메라 사이의 초기 거리 계산
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // 플레이어의 현재 위치에 오프셋 추가
        Vector3 targetPosition = player.position + offset;

        // x, y 좌표를 맵 범위 내로 제한
        targetPosition.x = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);

        // 부드럽게 카메라 이동
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
}
