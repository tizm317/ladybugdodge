using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasicEnemy : MonoBehaviour
{
    public int hp = 3;
    public void TakeDamage(int damage)
    {
        hp = hp - damage;
    }
    
    
}
