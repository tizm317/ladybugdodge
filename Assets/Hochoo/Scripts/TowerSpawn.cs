using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerSpawn : MonoBehaviour
{
    public GameObject[] Tower;

    public GameObject[] Place;

    public Transform[] Tr;

    public float spawnTime;
    public float curTime;

    public int TowerCount = 0;
    int Accumulated_TowerCount_per_stage = 0; // stage 당 누적 타워카운트

    public int PlaceRanNum;

    // stage
    public int stage = 0;
    public bool spawning = false;
    public bool StageUp = false;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        // stage 당 spawn 시스템
        if (spawning == true)
        {
            curTime += Time.deltaTime;
            if (curTime >= spawnTime)
                TowerPlace();
        }

        if (TowerCount == 0 && curTime == 0)
        {
            stage++;
            StageUp = true; // text 용
            Accumulated_TowerCount_per_stage = 0;
            spawning = true;
        }
        else
            StageUp = false;
        

        if (Accumulated_TowerCount_per_stage == stage)
            spawning = false;

        //문제2 해결
        if (stage > 8 && TowerCount == 8)
            curTime = 0;

        // 문제 1 : 예시 : stage 가 6 임 , 그러면 Tower 도 6개 생겨야함. 근데 타워 생기는 도중에 한개를 부숨 그러면 총 7개가 생기는 거임 // 누적 타워 카운트 가 필요
        // 해결법 : stage 당 누적 타워카운트 만들고 누적 타워 카운트랑 stage 랑 같으면 스폰 중지 + 누적 타워카운트는 stage 바뀌면 초기화
        // Accumulated_TowerCount_per_stage

        // 문제 2 : stage 가 8을 넘어갈 때, TowerCount 는 8을 넘지 못하기 때문에 spawning 이 계속 true 여서 계속 작동 but curtime 이 계속 돌뿐 눈에 보이는 문제는 없음
        // 소소한 문제는 타워를 부수자마자 다시 생겨남 , 누적 타워 카운트 덕분에 타워 갯수 정확하긴 함
        // 해결법 : curtime 이 잠시 멈출 수 있는 방안 마련
        // if(stage > 8 && TowerCount == 8) 



        //Instantiate(enemy, spawnPoints[ranNum]);
    }

    GameObject RandomTower()
    {
        int TowerRanNum = Random.Range(0, 5);

        return Tower[TowerRanNum];
    }

    void TowerPlace()
    {
        //위치 8곳 중 랜덤
        PlaceRanNum = Random.Range(0, 8);

        //위치 배열이 비어있으면
        if (Place[PlaceRanNum] == null)
        {
            Place[PlaceRanNum] = RandomTower();

            Instantiate(Place[PlaceRanNum], Tr[PlaceRanNum]);

            TowerCount++;
            Accumulated_TowerCount_per_stage++;
            //stage++;
            curTime = 0;
        }
    }


}


