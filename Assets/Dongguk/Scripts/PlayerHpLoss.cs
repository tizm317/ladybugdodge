using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpLoss : MonoBehaviour
{

    //private float playerHP = 200.0f;
    public Image playerHpBar;
    float last_Hp = 10; // 직전 Hp

    Hp hp;
    /*
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Attacking_Bullet"))
        {
            playerHP -= 10.0f;
            playerHpBar.fillAmount -= 1 / 20.0f;
        }
    }
    */
    // Use this for initialization
    void Start()
    {
        hp = GameObject.Find("Character").GetComponent<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hp < last_Hp)
        {
            playerHpBar.fillAmount -= 1 / 10.0f;
            last_Hp = hp.hp;// 현재 Hp를 전 Hp에 입력
        }
    }
}
