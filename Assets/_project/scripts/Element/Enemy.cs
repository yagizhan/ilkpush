using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyManager _enemyManager;
    public void StartEnemy(EnemyManager enemyManager)
    {
        _enemyManager = enemyManager;
    }

    private void OnMouseDown()
    {
        _enemyManager.EnemyDestroyed(this);
        Destroy(gameObject);    
    }


}
