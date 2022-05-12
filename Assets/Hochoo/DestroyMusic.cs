using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void DestroyTitleMusic()
    {
        Destroy(GameObject.Find("TitleMusic"));
    }
}
