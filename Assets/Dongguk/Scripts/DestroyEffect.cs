using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float timer = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject)
            Destroy(this.gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
