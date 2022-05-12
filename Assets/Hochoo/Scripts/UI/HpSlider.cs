using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpSlider : MonoBehaviour
{

    Slider slHP;
    float fSliderBarTime;

    //private float playerHP = 200.0f;
    float last_Hp = 10; // 직전 Hp

    Hp hp;
    
    // Use this for initialization
    void Start()
    {
        slHP = GetComponent<Slider>();
        slHP.value = 1;
        hp = GameObject.Find("Character").GetComponent<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        hp = GameObject.Find("Character").GetComponent<Hp>();

        if (slHP.value <= 0) // 죽음
        {
            transform.Find("Fill Area").gameObject.SetActive(false);
            hp.dead = true;
        }
        else
        {
            transform.Find("Fill Area").gameObject.SetActive(true);
            hp.dead = false;
        }

        if (hp.hp < last_Hp) // 피격 당했을 시
        {
            slHP.value -= 1 / 10.0f;
            last_Hp = hp.hp;// 현재 Hp를 전 Hp에 입력
        }
        else if (hp.hp > last_Hp) // 체력이 회복하는 경우
        {

            slHP.value = 1f;
            last_Hp = hp.hp;
        }
    }
}
