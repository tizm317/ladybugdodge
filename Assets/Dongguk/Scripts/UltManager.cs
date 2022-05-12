using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltManager : MonoBehaviour
{
    public GameObject player;
    public double code;
    public string enemyList;
    public GameObject treeUltshot;
    


    

    void FireUlt()
    {
      
       
    }

    void WaterUlt()
    {

    }

    void TreeUlt()
    {
        Instantiate(treeUltshot);
    }

    void ThunderUlt()
    {
        
    }

    void SolidUlt()
    {

    }
    

    public void Skill_Upgrade_Button()
    {
        code = player.transform.GetComponent<Element>().player_element;

        switch (code)
        {
            case 1:
                code = 1.3;
                FireUlt();
                break;

            case 2:
                code = 2.3;
                WaterUlt();
                break;
            case 3:
                code = 3.3;
                TreeUlt();
                break;
            case 4:
                code = 4.3;
                ThunderUlt();
                break;
            case 5:
                code = 5.3;
                SolidUlt();
                break;
        }
            
    }
}
