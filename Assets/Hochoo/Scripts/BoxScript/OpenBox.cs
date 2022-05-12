using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : SupplyBox
{
    float HpbarSize;

    // Start is called before the first frame update
    void Start()
    {
        HpbarSize = Hpbar.transform.localScale.x;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (BoxHP == 0)
            openBox();
    }

    void OnCollisionEnter2D(Collision2D col2)
    {
        if (col2.gameObject.tag == "Attacking_Bullet")
        {
            BoxHP--;
            Hpbar.transform.localScale = new Vector3(Hpbar.transform.localScale.x - (HpbarSize / 10) , Hpbar.transform.localScale.y, Hpbar.transform.localScale.z);
        }
    }

    void openBox()
    {

        Hp_Potion.transform.position = this.gameObject.transform.position;
        Hp_Potion.SetActive(true);
        this.gameObject.SetActive(false);
    }

    

}
