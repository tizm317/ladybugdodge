using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private void Update()
    {
        if (hp <= 0)
        {
            SpawnManager._instance.enemyCount--;
            SpawnManager._instance.isSpawn[int.Parse(transform.parent.name) - 1] = false;
            Destroy(this.gameObject);
        }
    }
    public int hp = 3;
    public void TakeDamage(int damage)
    {
        hp = hp - damage;
    }
}
