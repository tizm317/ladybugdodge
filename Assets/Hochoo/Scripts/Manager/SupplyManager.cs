using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupplyManager : MonoBehaviour
{
    // 생성 되는 위치
    public GameObject Center;   //0
    public GameObject East;     //1
    public GameObject West;     //2
    public GameObject South;    //3
    public GameObject North;    //4

    int nextSpawnPlace; // 0~4
    Vector3 SpawnPlace;

    // 박스 오브젝트
    public GameObject Box;

    // UI
    public GameObject NoticeUI;

    // 보급 생성 시간
    public float SpawnTime = 90f;

    // NextSpawnPlace 조건
    bool IsPlayed = false;


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        SpawnTime -= Time.deltaTime;

        if (SpawnTime <= 5 && SpawnTime > 0)
        {
            if (IsPlayed == false)
                NextSpawnPlace();
            NoticeUI.SetActive(true);

        }
        else if (SpawnTime <= 0)
        {
            NoticeUI.SetActive(false);

            BoxSpawn();
            SpawnTime = 90f;
            IsPlayed = false;
        }


    }


    // 다음 위치

    void NextSpawnPlace()
    {
        nextSpawnPlace = Random.Range(0, 5);
        string place = " ";

        switch (nextSpawnPlace)
        {
            
            case 0:
                place = " 중앙에서 ";
                SpawnPlace = Center.transform.position;
                break;
            case 1:
                place = " 동쪽에서 ";
                SpawnPlace = East.transform.position;
                break;
            case 2:
                place = " 서쪽에서 ";
                SpawnPlace = West.transform.position;
                break;
            case 3:
                place = " 남쪽에서 ";
                SpawnPlace = South.transform.position;
                break;
            case 4:
                place = " 북쪽에서 ";
                SpawnPlace = North.transform.position;
                break;
        }
        NoticeUI.GetComponent<Text>().text = "잠시후" + place + " 신비한 기운이 돕니다.";

        IsPlayed = true;
    }

    void BoxSpawn()
    {
        /* 일정 시간 마다 지정된 위치(동서남북 중앙) 중 한 곳에서 스폰됨
         * 스폰되기 몇 초전에 알려줌
         * 필요 변수: 시간, 위치
         */
        Box.transform.position = SpawnPlace;
        Box.SetActive(true);

    }
}
