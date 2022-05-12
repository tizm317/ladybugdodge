using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxHp : MonoBehaviour
{
    //public GameObject Canvas;
    //public GameObject Box;
    //public Camera HpCamera;
    //Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(0, 0.7f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //var screenPos = Camera.main.WorldToScreenPoint(Box.transform.position + offset); // 몬스터의 월드 3d좌표를 스크린좌표로 변환
        //var localPos = Vector2.zero;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(Canvas.GetComponent<RectTransform>(), screenPos, HpCamera, out localPos); // 스크린 좌표를 다시 체력바 UI 캔버스 좌표로 변환
        //this.GetComponent<RectTransform>().localPosition = localPos; // 체력바 위치조정

    }
}
