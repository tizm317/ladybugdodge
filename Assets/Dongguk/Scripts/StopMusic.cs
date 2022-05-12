using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(GameObject.Find("TitleMusic"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
