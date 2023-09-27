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
            //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
        }
    }
}