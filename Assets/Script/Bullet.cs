using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Update()
    {
        //�����Ӹ��� ������Ʈ�� ������ǥ�󿡼� ������ 1�� ����ŭ ���ư���
        transform.Translate(Vector3.forward * 1f);
    }
}