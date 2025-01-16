using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // ĳ���� �̵� �ӵ�

    void Update()
    {
        // ���� �Է� �ޱ�
        float moveX = Input.GetAxis("Horizontal"); // A, D �Ǵ� ȭ��ǥ �¿� Ű
        float moveY = Input.GetAxis("Vertical");   // W, S �Ǵ� ȭ��ǥ ���Ʒ� Ű

        // �̵� ���
        Vector3 move = new Vector3(moveX, moveY, 0);

        // ĳ���� ��ġ ������Ʈ
        transform.position += move * speed * Time.deltaTime;
    }
}
