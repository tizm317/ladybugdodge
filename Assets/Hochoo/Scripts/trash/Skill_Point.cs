using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // button 사용하려면 UI 필요

public class Skill_Point : Skill_Upgrade // 스킬 업그레이드 상속 받음
{
    //public GameObject Upgrade_Button;
    //public GameObject Element_1;
    //public GameObject Element_2;
    //public GameObject player1;

    //double code_1 = 0;
    //double code_2 = 0;

    //public void Click_Upgarde_Button() // 눌렀을 때 반응하는 거
    //{
    //    code_1 = player.transform.GetComponent<Element>().player_element_code_1;
    //    code_2 = player.transform.GetComponent<Element>().player_element_code_2;


    //    if (Experience.skill_point != 0) // 스킬 포인트가 존재하면
    //    {
    //        // 버튼 두개 활성화
    //        Element_1.SetActive(true);
    //        Element_2.SetActive(true);
            
    //        if (code_1 == 0 && code_2 == 0) // 속성 둘다 없을 때
    //        {
    //            // 속성 없음
    //            // 버튼 비활성화
    //            Element_1.GetComponent<Button>().interactable = false;
    //            Element_2.GetComponent<Button>().interactable = false;
    //        }
    //        else if(code_1 != 0 && code_2 == 0) // 코드 1만 존재
    //        {
    //            Element_1.GetComponent<Button>().interactable = true;
    //            Element_2.GetComponent<Button>().interactable = false;
    //        }
    //        else if(code_1 == 0 && code_2 != 0) // 코드 2만 존재
    //        {
    //            Element_1.GetComponent<Button>().interactable = false;
    //            Element_2.GetComponent<Button>().interactable = true;
    //        }
    //        else // 코드 둘다 존재
    //        {
    //            Element_1.GetComponent<Button>().interactable = true;
    //            Element_2.GetComponent<Button>().interactable = true;
    //        }
    //        /*
    //        if(upgrade_bool) // 스킬 레벨 업 한 후 / 업그레이드 여부
    //        {
    //            // 스킬 포인트 감소
    //            //Skill_Upgarde_Button();
                
    //            // 스킬 포인트 0 되면 닫힘
    //            Element_1.SetActive(false);
    //            Element_2.SetActive(false);
    //        }
    //        */
    //    }
    //    else
    //        //스킬 포인트 부족하면
    //        Debug.Log("스킬 포인트가 부족합니다!");
    //}

    

    // Start is called before the first frame update
    void Start()
    {
        //Upgrade_Button.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
      //if(Experience.skill_point != 0)
      //      Upgrade_Button.GetComponent<Button>().interactable = true;

        if (upgrade_bool == true) // 스킬 레벨 업 한 후 / 업그레이드 여부
        {
            upgrade_bool = false; // 업그레이드 여부 초기화
            if (Experience.skill_point < 1) // 스킬 포인트 다 썼을 경우
            {
                Debug.Log("스킬 포인트를 다 썼습니다!!!!!");
                //Upgrade_Button.GetComponent<Button>().interactable = false;
                //Element_1.SetActive(false); // 비활성화
                //Element_2.SetActive(false);
            }
      }
            
        
    }
}
