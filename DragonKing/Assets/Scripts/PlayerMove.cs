using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // 캐릭터 이동 속도

    void Update()
    {
        // 방향 입력 받기
        float moveX = Input.GetAxis("Horizontal"); // A, D 또는 화살표 좌우 키
        float moveY = Input.GetAxis("Vertical");   // W, S 또는 화살표 위아래 키

        // 이동 계산
        Vector3 move = new Vector3(moveX, moveY, 0);

        // 캐릭터 위치 업데이트
        transform.position += move * speed * Time.deltaTime;
    }
}
