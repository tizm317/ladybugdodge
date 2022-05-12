using UnityEngine;
public class PlayerMissile_Move : MonoBehaviour
{
    private float MoveSpeed = 10; // 미사일이 날라가는 속도 / Player_Fire 에도 있음 맞춰야함
    //public float DestroyYPos; // 미사일이 사라지는 지점 y축
    //public float DestroyXPos; // 미사일이 사라지는 지점 x축
    //public float DestroyRadius; 

    public float lifeTime = 0.5f; // 미사일 lifetime , 밑에 초기화 할 때 처음 설정값과 똑같이 해야함

    double code = 0.0;

    JoyStick_R joystick_r;
    Vector2 vec2;


    

    private void Awake()
    {
        joystick_r = GameObject.Find("JoyStick_R").GetComponent<JoyStick_R>();
        
    }

    private void OnDisable()
    {
        joystick_r.IsShooting = false;
    }

    void Update ()
    {
        // 총알 속성 받아오는 코드
        if (transform.GetComponent<BulletCode>())
            code = transform.GetComponent<BulletCode>().code;


        // 매 프레임마다 미사일이 MoveSpeed 만큼 up방향(Y축 +방향)으로 날라갑니다.
        MissileMove(); // 기본공격 + 속성 레벨 1

        
        
        lifeTime -= Time.deltaTime;

        /* 미사일이 사라지는 경우
           1. 설정된 x,y 축 값을 벗어나는 경우 (맵을 벗어나는 경우)
           2. 설정된 lifeTime 끝날경우
           3. 장애물/적 과 충돌 할 경우 : 데미지를 입힘

            // 마지막에 lifeTime 초기화 시켜야 함 , 초기화 할 때 초기값과 동일하게 설정해야함
        */

        // 1.만약에 미사일의 위치가 DestroyYPos를 넘어서면 (절대값으로 설정)
        //if (Mathf.Abs(transform.position.x) >= DestroyXPos)
        //{
        //    // 미사일을 다시 메모리 풀에
        //    GetComponent<Collider2D>().enabled = false;
        //}
        //else if(Mathf.Abs(transform.position.y) >= DestroyYPos)
        //{
        //    // 미사일을 다시 메모리 풀에
        //    GetComponent<Collider2D>().enabled = false;
        //}

        // 2. lifetime 끝나면
        if (lifeTime <= 0)
        {
            // 미사일을 다시 메모리 풀에
            GetComponent<Collider2D>().enabled = false;
            
            
        }

       

        // lifeTime 초기화 , IsShooting 초기화 ( 발사 끝났으니 꺼줘야지)
        if (GetComponent<Collider2D>().enabled == false)
        {

            joystick_r.IsShooting = false;
            lifeTime = 0.5f;
        }
    }

    //3. 장애물/적 과 충돌 할 경우 + 데미지를 입힘(Hp : 현재 experience 에서 관리)
    //OnColliderEnter2D(Collider2D ) 이거 썼었는데 Hp 가 두배로 줄어서 뭐가 문제지 하고 찾아보니 이거는 통과할 때 사용하는 거고 + IsTrigger 둘다 켜져있어야함
    //Collision 을 쓰면 충돌 하는 경우임 + IsTrigger 둘다 꺼져 있어야 하고
    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Player")
    //    {
    //        GetComponent<Collider2D>().enabled = false;
    //        lifeTime = 0.5f;
    //    }
    //    else if (col.gameObject.tag == "Map")
    //    {
    //        //3. 맵 경계 만나면 사라짐
    //        //Debug.Log("맵 경계");
    //        GetComponent<Collider2D>().enabled = false;

    //    }
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<Collider2D>().enabled = false;
            lifeTime = 0.5f;
        }
    }


    void MissileMove()
    {
        switch (code)
        {
            case 0: // 기본 속성
                //Debug.Log(joystick_r.PointerUpVect.normalized + "이건가3");
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
            case 1: // 화
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
            case 2: // 수
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
            case 3: // 목
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
            case 4: // 금
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
            case 5: // 토
                transform.Translate(joystick_r.PointerUpVect.normalized * MoveSpeed * Time.deltaTime);
                break;
        }
    }
    
}