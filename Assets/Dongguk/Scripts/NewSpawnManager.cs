using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnManager : MonoBehaviour
{
    public Transform[] points;
    public GameObject monster;
    public float creatTime = 3.0f;

    public GameObject[] Tower = null;

    public GameObject[] Mons;

    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.Find("SpawnPoint").GetComponentsInChildren<Transform>();
        StartCoroutine(this.CreateTower());


    }
    IEnumerator CreateTower()
    {
        while (true)
        {

            int idx = Random.Range(0, points.Length);


            if (Tower[idx] == null)
            {
                //Tower[idx] = Instantiate(RandomTower(), points[idx].position, Quaternion.identity);
            }
            

            yield return new WaitForSeconds( creatTime );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject RandomTower()
    {
        return Mons[Random.Range(0, 5)];
    }
}

