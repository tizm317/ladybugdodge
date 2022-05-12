using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    public float spawnTime;
    public float curTime;
    public int maxCount;
    public int enemyCount;
    public static SpawnManager _instance;
    public bool[] isSpawn;


    private void Start()
    {
        isSpawn = new bool[spawnPoints.Length];
        for (int i = 0; i < isSpawn.Length; i++)
        {
            isSpawn[i] = false;
        }
        _instance = this;
    }

    private void Update()
    {
        if(curTime >= spawnTime && enemyCount<maxCount)
        {
            int x = Random.Range(0, spawnPoints.Length);
            if(!isSpawn[x])
            SpawnEnemy(x);
        }
        curTime += Time.deltaTime;
    }

    public void SpawnEnemy(int ranNum)
    {
        
        curTime = 0;
        enemyCount++;
        
        Instantiate(enemy, spawnPoints[ranNum]);
        isSpawn[ranNum] = true;
    }
}
    
