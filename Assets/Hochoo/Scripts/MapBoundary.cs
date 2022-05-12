using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBoundary : MonoBehaviour
{
    Joy_stick joystick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("맵 경계임!");
            //StartCoroutine(RotateAngle(collider.gameObject, 180, -1));
            StartCoroutine(GoBack(collider.gameObject, 180, -1));
        }
    }
    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("맵 경계임!");
            StartCoroutine(RotateAngle(collision.gameObject, 180, -1));
        }
    }
    */
    IEnumerator RotateAngle(GameObject col, float angle, int sign)
    {
        float mod = angle % 5f; // 남은 각도 계산
        for (float i = mod; i < angle; i += 5f)
        {
            col.transform.Rotate(0, 0, sign * 5f); // 캐릭터 rotateSpeed만큼 회전
            yield return new WaitForSeconds(0.01f); // 0.01초 대기
        }
        col.transform.Rotate(0, 0, sign * mod); // 남은 각도 회전
    }

    IEnumerator GoBack(GameObject col, float angle, int sign)
    {
            col.transform.Rotate(0, 0, -180f); // 캐릭터 rotateSpeed만큼 회전
            yield return new WaitForSeconds(0.01f); // 0.01초 대기
    }
}
