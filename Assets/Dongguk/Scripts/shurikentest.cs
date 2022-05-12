using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikentest : MonoBehaviour
{

    public GameObject Bullet;
    public Transform FirePos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
            transform.Translate(Vector3.forward * 1f);
        }
    }
}



