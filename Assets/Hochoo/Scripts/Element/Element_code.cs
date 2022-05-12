using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element_code : GameManager
{
    public int element_code = 0; // 기본 속성 '0' 제외, 총 5개 속성 (1,5)
    int random;

    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
            // 자연 생성되는 구슬

            random = Random.Range(1, 6); // 주의
            element_code = random;
        
    }

    // Update is called once per frame
    void Update()
    {

}
}



//if(FromDeadPlayer)
//        {
//            Debug.Log("DEAD");
//            // 죽은 플레이어 한테서 나오는 구슬
//            /*
//            Debug.Log(FromDeadPlayer);
//            Debug.Log(WhoDie + " is dead");
//            Debug.Log(WhoDie.transform.GetComponent<Element>().player_element + " is dead player's element");
//            */
//            if (WhoDie.transform.GetComponent<Element>().player_element_code_1 != 0 && WhoDie.transform.GetComponent<Element>().player_element_code_2 != 0)
//            {
//                if(FirstElement == null)
//                {
//                    element_code = (int) WhoDie.transform.GetComponent<Element>().player_element_code_1;
//                    Debug.Log("1번째");
//                }
//                else
//                {
//                    element_code = (int) WhoDie.transform.GetComponent<Element>().player_element_code_2;
//                    Debug.Log("2번째");
//                }
//                Debug.Log("뭐지?");
//                // 속성 2개일때
//                // DropTwoElement 에서 이어짐
//            }
//            else
//                // 속성 하나
//                element_code = (int) WhoDie.transform.GetComponent<Element>().player_element;

//            //FromDeadPlayer = false;
//        }
//        else
//        {
//    }
        //Debug.Log(element_code);