using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // �̵� �ӵ�

    void Update()
    {
        float moveInputX = 0.0f;
        float moveInputZ = 0.0f;

        // W Ű�� ������ ����
        if (Input.GetKey(KeyCode.W))
            moveInputZ = 1.0f;

        // S Ű�� ������ ����
        if (Input.GetKey(KeyCode.S))
            moveInputZ = -1.0f;

        // A Ű�� ������ �������� �̵�
        if (Input.GetKey(KeyCode.A))
            moveInputX = -1.0f;

        // D Ű�� ������ ���������� �̵�
        if (Input.GetKey(KeyCode.D))
            moveInputX = 1.0f;

        // �̵� ���� ����
        Vector3 movement = new Vector3(moveInputX, 0.0f, moveInputZ);
        movement.Normalize();  // �밢�� �̵� �� ������ �ӵ��� �����ϱ� ���� ����ȭ

        // �̵� ���Ϳ� �ӵ��� ���Ͽ� �̵�
        Vector3 moveDirection = transform.TransformDirection(movement);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
