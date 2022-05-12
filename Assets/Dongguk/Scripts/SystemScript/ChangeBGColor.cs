using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBGColor : MonoBehaviour
{
    public Change_Night Changethis;
    public SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Changethis)
        {
            render.color = new Color(1, 1, 1, 1);
        }
        
    }
}
    


