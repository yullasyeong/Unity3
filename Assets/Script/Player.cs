using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // 이동 속도

    void Update()
    {
        float moveInputX = 0.0f;
        float moveInputZ = 0.0f;

        // W 키를 누르면 전진
        if (Input.GetKey(KeyCode.W))
            moveInputZ = 1.0f;

        // S 키를 누르면 후진
        if (Input.GetKey(KeyCode.S))
            moveInputZ = -1.0f;

        // A 키를 누르면 왼쪽으로 이동
        if (Input.GetKey(KeyCode.A))
            moveInputX = -1.0f;

        // D 키를 누르면 오른쪽으로 이동
        if (Input.GetKey(KeyCode.D))
            moveInputX = 1.0f;

        // 이동 방향 설정
        Vector3 movement = new Vector3(moveInputX, 0.0f, moveInputZ);
        movement.Normalize();  // 대각선 이동 시 일정한 속도를 유지하기 위해 정규화

        // 이동 벡터에 속도를 곱하여 이동
        Vector3 moveDirection = transform.TransformDirection(movement);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
