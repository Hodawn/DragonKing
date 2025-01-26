using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform
    public Vector2 minBounds; // ���� �ּ� ��ǥ
    public Vector2 maxBounds; // ���� �ִ� ��ǥ
    public float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�

    private Vector3 offset; // ī�޶�� �÷��̾� ���� �Ÿ�

    void Start()
    {
        // �÷��̾�� ī�޶� ������ �ʱ� �Ÿ� ���
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // �÷��̾��� ���� ��ġ�� ������ �߰�
        Vector3 targetPosition = player.position + offset;

        // x, y ��ǥ�� �� ���� ���� ����
        targetPosition.x = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);

        // �ε巴�� ī�޶� �̵�
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
}
