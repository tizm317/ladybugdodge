using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : GameManager
{
    /* if(체력 == 0) 
     * 캐릭터 죽음
     * [죽을 때 이펙트 (펑!)
     * = 조이스틱 움직여도 캐릭터 이동 x (o)
     * -가진 거 떨구는 이펙트 , 애니메이션
     * -캐릭터가 가진 속성 구슬 떨굼 
     * -캐릭터의 누적 경험치(score) 구슬로 떨굼 (o)
     * -당연히 레벨 0 경험치 0 스킬레벨 0 스킬 포인트 0 리셋 -> 우측 조이스틱 움직여도 아무 작용 x
     * 캐릭터 투명화( 점점 투명해지되 반투명) (현재는 그냥 반투명)
     * 캐릭터 충돌 감지 x (o)
     * 화면 점점 어두워짐(완전 어두워지는 건 아님) 어느정도 어두워지면(혹은 한번 클릭하면) 점수창(UI)(다시하기/옵션) 같은게 뜸]
     * Game Over 글씨 뜸
     * 
     */


    public Slider slHP;
    Element element;

    bool IsPlayed = false; 
    int count_element = 0;
    int count_exp = 0;


    float RandomX;
    float RandomY;

    int count = 0; //

    public GameObject foodPrefab;
    public float force = 0f;
    public Vector3 offset = Vector3.zero;

    public GameObject panel;
    
    float Alpha = 0f;

    

    void SpreadOut()
    {
        // 구슬들이 시체에서 주변으로 퍼지는 효과
        GameObject t_clone = Instantiate(foodPrefab, transform.position, transform.rotation);
        Rigidbody[] t_rigids = t_clone.GetComponentsInChildren<Rigidbody>();
        for(int i = 0; i < t_rigids.Length; i++)
        {
            t_rigids[i].AddExplosionForce(force, transform.position + offset, 5);
        }

    }

    void DropElement()
    {
        /* 플레이어의 속성 갯수에 따라 구슬 개수 결정 */
        /*
        if(element.player_element != 0) 
        {
            // 주속성 존재 (최소 한개 이상의 속성)
            if(element.player_element_code_1 !=0 && element.player_element_code_2 !=0)
            {
                // 속성 2개 존재
                while(count_element < 2)
                {
                    RandomX = Random.Range(-2f, 2f);
                    RandomY = Random.Range(-2f, 2f);

                    ObjectManager.instance.GetElement(new Vector2(transform.position.x + RandomX, transform.position.y + RandomY));
                    count_element++;
                }
            }
            else
            {
                //속성 1개 (주속성만 버리면 됨)
                while(count_element < 1)
                {
                    RandomX = Random.Range(-2f, 2f);
                    RandomY = Random.Range(-2f, 2f);

                    ObjectManager.instance.GetElement(new Vector2(transform.position.x + RandomX, transform.position.y + RandomY));
                    count_element++;
                }
            }
            
        }
        */
        
    }

    void DropEXP()
    {
        /*
        while(count_exp < 5) // 4개 생김
        {
            //Debug.Log(count_exp);

            RandomX = Random.Range(-2f,2f);
            RandomY = Random.Range(-2f,2f);

            ObjectManager.instance.GetFood(new Vector2(transform.position.x + RandomX, transform.position.y + RandomY));
            count_exp++;
        }
        */
        for(int i = 0; i < Experience.score; i++)
        {
            RandomX = Random.Range(-2f, 2f);
            RandomY = Random.Range(-2f, 2f);

            ObjectManager.instance.GetFood(new Vector2(transform.position.x + RandomX, transform.position.y + RandomY));
        }

            
    }

    void ResetElement()
    {
        gameObject.transform.GetComponent<Element>().player_element = 0;
        gameObject.transform.GetComponent<Element>().player_element_code_1 = 0;
        gameObject.transform.GetComponent<Element>().player_element_code_2 = 0;
    }

    // 색깔 서서히 바꾸기
    IEnumerator ChangeAlpha()
    {
        const float maxTime = 3.0f;
        float currentTime = 0.0f;

        while (true)
        {
            currentTime += Time.deltaTime;

            if (currentTime > maxTime)
            {
                currentTime = 0.0f;
                Alpha = Alpha + (1f / 255);
                if (Alpha > (50 / 255))
                    yield return null;
                panel.GetComponent<Image>().color = new Color(0, 0, 0, Alpha);
            }

            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        element = transform.GetComponent<Element>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (slHP.value <= 0)
        {
            Joy_stick.speed = 0; // 움직임 0
            gameObject.transform.GetComponent<CircleCollider2D>().enabled = false; // 충돌 끔
           
            gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f); // 반투명

            panel.SetActive(true);
            StartCoroutine(ChangeAlpha());
            //panel.GetComponent<Image>().color = new Color(0, 0, 0, Alpha);

            if (IsPlayed == false)
            {
                if (FromDeadPlayer == false)
                {
                    //FromDeadPlayer = true;
                    //WhoDie = gameObject;
                    
                    DropEXP();
                    SpreadOut();
                    IsPlayed = true;
                    ResetElement(); // 속성 0 으로 바꿈
                }
            }
            
            

        }
    }
    
}
