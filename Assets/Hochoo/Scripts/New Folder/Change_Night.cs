using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Night : MonoBehaviour
{
    public Text timeText;
    float Timer = 10;

    public GameObject Lit;
    public GameObject Spot_lit;
    public GameObject DayTime;
    public GameObject NightTime;

    public GameObject time_effect;
    public GameObject player;
    //float lifetime = 1.0f;

    bool IsNight = false;

    public Slider slTimer;

    //하늘 배경용
    Camera cam;
    Color Originalcolor; // 낮 하늘

    void Disabled()
    {

        GameObject.Find("EffectManager").transform.GetChild(16).gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 하늘 배경
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Originalcolor = cam.backgroundColor;
    }
    /*
    void Time_Effect()
    {
        Instantiate(time_effect, player.transform.position, player.transform.rotation);
        Destroy(time_effect, lifetime);
    }
    */
    // Update is called once per frame
    void Update()
    {
        //Lit.GetComponent<Light>().intensity -= Time.deltaTime / 10;
        if (Timer > 0)
        {
            /* 시계 이미지 */
            if (DayTime.GetComponent<Image>().fillAmount < 0.6) 
                DayTime.GetComponent<Image>().fillAmount += Time.deltaTime / 100 * 6;
            else 
                NightTime.GetComponent<Image>().fillAmount += Time.deltaTime / 100 * 4;
            if (NightTime.GetComponent<Image>().fillAmount > 0.4) // 낮
            {
                DayTime.GetComponent<Image>().fillAmount = 0;
                NightTime.GetComponent<Image>().fillAmount = 0;
            }


            //Timer -= Time.deltaTime /3; 
            timeText.text = string.Format("{0:N1}", Timer);
            if (IsNight)
            {
                Timer -= Time.deltaTime;

                //밤 -> 낮
                slTimer.value = 10 - Timer;
                
                // 밤 하늘
                cam.backgroundColor = Color.black;

            }
            else
            {
                Timer -= Time.deltaTime / 3;
                //낮 -> 밤
                slTimer.value = Timer;

                // 낮 하늘
                cam.backgroundColor = Originalcolor;

            }

        }
        else
        {
            Timer = 10;
            if(IsNight)
            {
                //밤 -> 낮
                GameObject.Find("EffectManager").transform.GetChild(16).gameObject.transform.position = player.transform.position;
                GameObject.Find("EffectManager").transform.GetChild(16).gameObject.SetActive(true);

                Invoke("Disabled", 1);
                //Time_Effect();
                Lit.SetActive(true);
                Spot_lit.SetActive(false);
                IsNight = false;
            }
            else
            {
                GameObject.Find("EffectManager").transform.GetChild(16).gameObject.transform.position = player.transform.position;

                GameObject.Find("EffectManager").transform.GetChild(16).gameObject.SetActive(true);
                Invoke("Disabled", 1);

                //Time_Effect();
                //낮 -> 밤
                Lit.SetActive(false);
                Spot_lit.SetActive(true);
                IsNight = true;
            }
            
        }

    }
}
