using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 게임 전체 상황 관리
    // 1. 누가 죽었는지

    static public GameObject WhoDie;
    public bool FromDeadPlayer = false;
    static public int[] ElementList; // 죽은 사람이 가지고 있던 속성 배열

    public GameObject FirstElement;
    public GameObject SecondElement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
