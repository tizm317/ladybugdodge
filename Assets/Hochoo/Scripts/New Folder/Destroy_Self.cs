using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Self : MonoBehaviour
{
    private float lifeTime = 5.0f;
    float _time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //if (this.gameObject)
        //    Destroy(this.gameObject, lifeTime);
        
        //StartCoroutine(Disabled());
        
    }

    private void FixedUpdate()
    {
        _time += Time.fixedDeltaTime;
        if (_time >= lifeTime)
        {
            this.gameObject.SetActive(false);
            _time = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //_time += Time.deltaTime;
        
    }
    /*
    IEnumerator Disabled()
    {
        yield return new WaitForSeconds(lifeTime);
        gameObject.SetActive(false);
        Debug.Log("비활성화");
    }
    */
}
