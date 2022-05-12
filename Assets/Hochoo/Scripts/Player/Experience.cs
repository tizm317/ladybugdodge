using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    /* LvUp Effect */
    static public GameObject EffectList;
    int i = 26; // skill level up effect : 26
    int j = 42; // player heal effect  : 42
    

    /* experience */
    [Range(0,20)]
    static public int experience = 0;
    static public int level = 1;

    static public int score = 0; // 나중에 그냥 experience 쓸수도 있음 / 누적 경험치 = 점수

    /* skill points */
    static public int skill_point = 0;

    /* skill Level */


    static public bool levelup = false;

    private void Awake()
    {
        // static 변수들은 씬 재로딩 시 초기화 x
        // awake 나 start 에서 다시 초기화
        experience = 0;
        level = 1;
        skill_point = 0;
        levelup = false;
        score = 0;
    }


    /*Lv Up Effect */
    // Start is called before the first frame update
    void Start()
    {
        EffectList = GameObject.Find("EffectManager").gameObject;
        
    }

    public void Disabled()
    {
        EffectList.transform.GetChild(i).gameObject.SetActive(false);
        EffectList.transform.GetChild(j).gameObject.SetActive(false);
    }

    void LV_UP_Effect()
    {
        //Instantiate(element, transform.position, transform.rotation);
        //Destroy(element, lifetime);

        EffectList.transform.GetChild(i).gameObject.SetActive(true);
        EffectList.transform.GetChild(i).gameObject.transform.position = transform.position;
        Invoke("Disabled", 1);
    }

    void Healing_Effect() 
    {

        EffectList.transform.GetChild(j).gameObject.SetActive(true);
        EffectList.transform.GetChild(j).gameObject.transform.position = transform.position;
        Invoke("Disabled", 1);
    }

        



    




    ///* element code */
    //static public int element_code; // 속성 구슬의 코드를 받아와야함 ..
    //public int player_element_code = 0; // 플레이어의 코드

    //int eaten_element_code; // 충돌한 속성 구슬 의 속성값

    /*
public GameObject elementalchange1;
public GameObject elementalchange2;
public GameObject elementalchange3;

public float effectlifetime = 1.0f;
*/

    /* Hp */
    // 문제 발생! 경험치 코드에서 모든 캐릭터의 경험치랑 Hp 를 관리 하다보니 하나의 통합된 경험치와 Hp 를 공유하는듯.. 아마 static 영향인지도
    //static public int Hp = 10;

    

    // OnTriggerEnter2D(Collider2D ) 이거 썼었는데 Hp 가 두배로 줄어서 뭐가 문제지 하고 찾아보니 이거는 통과할 때 사용하는 거고 + IsTrigger 둘다 켜져있어야함
    // Collision 을 쓰면 충돌 하는 경우임 + IsTrigger 둘다 꺼져 있어야 하고


    /* 문제 해결 */
    // 체력이 내가 발사할 때도 달음...;;; -> Layer 설정으로 막음

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Food")
        {
            //Destroy(col.gameObject);
            col.gameObject.SetActive(false); //비활성화
            //Debug.Log("ExperienceUp!!");
            experience++;
            score++;
            
        }
        //else if(col.gameObject.tag == "Element")
        //{
        //    eaten_element_code = col.gameObject.GetComponent<Element_code>().element_code; // 충돌한 속성 구슬 의 속성값 대입
        //    Element();  // 문제 있음
        //    Destroy(col.gameObject);
        //}
        
    }


   
    /*
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Attacking_Bullet")
        {
            Hp--;
            Debug.Log("Hp down");
        }
    }
    */
    /*
    void OnCollisionEnter2D(Collision2D col2)
    {
        if(col2.gameObject.tag == "Attacking_Bullet")
        {
            Hp--;
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        LevelUp();
        
    }

    void Heal()
    {
        GameObject.Find("Character").GetComponent<Hp>().hp  = 10;
        Healing_Effect();
      
    }

    void LevelUp()
    {
        if (level < 10) // 최고 레벨 10
        {
            if (experience >= 10 * level)
            //if (experience == 2) // 1렙(2렙까지 필요 경험치 : 10 ) 2렙(3렙까지 필요 경험치 : 20) 
            {
                level++;
                Heal();
                experience -= 10 * level;
                skill_point++;
                LV_UP_Effect();
                levelup = true;
            }
        }
    }
    /*
    void Element() // 어차피 이미 각 엘레멘트 마다 code 가 달리 설정되어 있음 / 여기서는 code 를 보고 player 에 적용하는 스크립트 작성
    {
        //현재 Element_code.element_code 가 충돌한 속성 구슬거가 아니라 가장 최근 생성된 구슬의 것(가장 최근 실행된 스크립트)
        // 해결책 충돌한 속성 구슬의 Element_code.element_code 받아와야함**** (해결) (갑자기 오류 사라짐)

        if(eaten_element_code == 1) // 내가 먹은 속성 구슬의 코드가 1일때
            
        {
            player_element_code = 1;
            //Instantiate(elementalchange1, transform.position, transform.rotation);
            //Destroy(elementalchange1, effectlifetime);
        }
        else if(eaten_element_code == 2)
            player_element_code = 2;
        else if (eaten_element_code == 3)
            player_element_code = 3;
        else if (eaten_element_code == 4)
            player_element_code = 4;
        else if (eaten_element_code == 5)
            player_element_code = 5;
    }
    */
}
