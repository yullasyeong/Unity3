using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject Bullet;
    public Transform FirePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //�����Ѵ�. //'Bullet'�� 'FirePos.transform.position' ��ġ�� 'FirePos.transform.rotation' ȸ��������.
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
        }
    }
}