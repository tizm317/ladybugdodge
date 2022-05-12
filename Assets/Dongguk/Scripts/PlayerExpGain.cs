using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExpGain : MonoBehaviour
{

    //public float playerExp = 100.0f;
    public Image playerExpBar;
    int last_exp = 0; // 직전 경험치
  
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Experience.experience> last_exp ) // 경험치 오를때마다 (더 좋은 방법이 있을거같은데 생각안남)
        {
            playerExpBar.fillAmount += 1 / (10.0f * Experience.level) ;
            last_exp = Experience.experience; // 현재 경험치를 전 경험치에 입력

        }
        if (playerExpBar.fillAmount >= 1) // exp 바 꽉 차면(레벨 업) 다시 0으로 바꿈 , 경험치 자체가 줄진 않음
        {
            playerExpBar.fillAmount = 0;
            last_exp = 0; // 전 경험치도 비워주어야 정상 작동
        }
    }
}
