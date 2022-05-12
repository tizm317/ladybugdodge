using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupplyBox : MonoBehaviour
{
    /* 보급 상자
         * 체력을 가지고 있어서 체력이 다 달아야 열림
         * 일정 시간 후에 사라짐 ( 안 그러면 쌓이는 경우가 생길 수 있어서)
         * 필요 변수: 체력, 시간
         */


    //public GameObject prfHpbar;
    //public GameObject Canvas;
    public GameObject Box;
    public GameObject Hpbar;
    public GameObject NoticeUI;

    RectTransform hpBar;

    public float height = 1.7f;

    // 보급 상자 하나의 생존 시간
    public float RunTime = 60f;
    public int BoxHP;

    // 포션 오브젝트
    public GameObject Hp_Potion;

    private void Start()
    {
        //hpBar = Instantiate(prfHpbar, Canvas.transform).GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        BoxHP = 10;
        Hpbar.transform.localScale = new Vector3(0.17f, 0.08f, 1f);
        RunTime = 60f;
    }

    private void Update()
    {
        //Vector3 _hpBarPos = Camera.main.WorldToScreenPoint(new Vector3(Box.transform.position.x, Box.transform.transform.position.y, 0));
        //hpBar.transform.position = _hpBarPos;
            //Camera.main.WorldToScreenPoint(transform.position + new Vector3(0,1f,0));

        RunTime -= Time.deltaTime;
        RunTimeOver();
    }

    void RunTimeOver()
    {
        // 상자 실행 시간 초과
        if (RunTime <= 0)
        {
            NoticeUI.SetActive(true);
            NoticeUI.GetComponent<Text>().text = " 신비한 기운이 사라집니다.";
            Invoke("StopNoticeUI", 5);
            this.gameObject.SetActive(false);
        }
    }

    void StopNoticeUI()
    {
        NoticeUI.SetActive(false);
    }
}
