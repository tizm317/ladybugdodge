using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    /*총알 자동 발사*/
    /*
        문제점: 플레이어는 계속 움직임
        해결책: 총알의 움직임이 '플레이어를 기준'으로 따라온다

       1. 총알 생성
            - 실시간 플레이어의 위치를 받아온다
            - 받아온 위치에 
            - 프리팹으로 소환
            - 총알에 부딪히면 특정 데미지만큼 체력 담 On
       2. 총알 이동
            - 일정 속도로
            - 정해진 거리까지 / or 시간동안
            - 이동
            - 총알에 부딪히면 데미지 -ing
       3. 총알 삭제
            - 상대/벽 에 부딪히면 총알 삭제
            - 정해진 거리에 도달하면 / or 시간이 지나면
            - destroy
         */

    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1, 1);
    }

    void SpawnBullet() // bullet 생성
    {
        if (true)
        {
            GameObject bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }

    void Shoot()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
