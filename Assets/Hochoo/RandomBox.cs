using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class RandomBox : MonoBehaviour
{
    bool code1Max = false;
    bool code2Max = false;
    public bool RandomBoxPlayed = false;
    public int PointsRequired = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Element element = GameObject.Find("Character").GetComponent<Element>();

        if (element.player_element_code_1 == 1.2 || element.player_element_code_1 == 2.2 || element.player_element_code_1 == 3.2 || element.player_element_code_1 == 4.2 || element.player_element_code_1 == 5.2)
            code1Max = true;
        else
            code1Max = false;

        if (element.player_element_code_2 == 1.2 || element.player_element_code_2 == 2.2 || element.player_element_code_2 == 3.2 || element.player_element_code_2 == 4.2 || element.player_element_code_2 == 5.2)
            code2Max = true;
        else
            code2Max = false;


        if (code1Max && code2Max)
        {
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.transform.GetChild(3).gameObject.SetActive(true);
        }
        else
        {
            this.transform.GetChild(2).gameObject.SetActive(true);
            this.transform.GetChild(3).gameObject.SetActive(false);
        }

    }


    public void RandomItem()
    {

        if (Experience.skill_point >= PointsRequired)
        {
            // 포인트 소모 : 5 -> 10 -> 15
            Experience.skill_point -= PointsRequired;
            RandomBoxPlayed = true;
            PointsRequired += 5;

            switch(UnityEngine.Random.Range(1,10))
            {
                case 1:
                    // 공격력 증가

                    break;

            }
        }
        else
        {
            Debug.Log("랜덤 박스를 열려면 " + PointsRequired + " 만큼 필요합니다.");
            // PointsRequired 알려줌
            // 부족하다고 알림
        }
    }


    
}
